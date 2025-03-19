using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Data;
using Survivor.Entities;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly SurvivorDbContext _context;

        public CompetitorController(SurvivorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompetitorsEntity>>> GetCompetitors()
        {
            return await _context.Competitors.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompetitorsEntity>> GetCompetitor(int id)
        {
            var competitor = await _context.Competitors.FindAsync(id);
            if (competitor == null) return NotFound();
            return competitor;
        }

        [HttpGet("categories/{categoryId}")]
        public async Task<ActionResult<IEnumerable<CompetitorsEntity>>> GetCompetitorsByCategory(int categoryId)
        {
            return await _context.Competitors.Where(c => c.CategoryId == categoryId).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<CompetitorsEntity>> CreateCompetitor([FromBody] CompetitorsEntity competitor)
        {
            // CategoryId'nin geçerli olup olmadığını kontrol et
            if (competitor.CategoryId == 0)
            {
                return BadRequest(new { message = "CategoryId is required and must be greater than zero." });
            }

            // Geçerli bir CategoryId'ye sahip olup olmadığını kontrol et
            var categoryExists = await _context.Categories.AnyAsync(c => c.Id == competitor.CategoryId);
            if (!categoryExists)
            {
                return BadRequest(new { message = "The provided CategoryId does not exist." });
            }

            // Veritabanına rakip ekle
            _context.Competitors.Add(competitor);
            await _context.SaveChangesAsync();

            // Başarıyla oluşturulmuş olan rakip verisini geri döndür
            return CreatedAtAction(nameof(GetCompetitor), new { id = competitor.Id }, competitor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompetitor(int id, CompetitorsEntity competitor)
        {
            if (id != competitor.Id) return BadRequest();

            // Veritabanında geçerli bir CategoryId'ye sahip olup olmadığını kontrol et
            var categoryExists = await _context.Categories.AnyAsync(c => c.Id == competitor.CategoryId);
            if (!categoryExists)
            {
                return BadRequest(new { message = "The provided CategoryId does not exist." });
            }

            _context.Entry(competitor).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompetitor(int id)
        {
            var competitor = await _context.Competitors.FindAsync(id);
            if (competitor == null) return NotFound();
            _context.Competitors.Remove(competitor);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
