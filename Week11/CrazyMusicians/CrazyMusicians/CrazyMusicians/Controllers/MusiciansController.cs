using CrazyMusicians.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusicians.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
        private static List<Musician> _musicians = new List<Musician>()
        {
            new Musician { Id = 1, Name = "Ahmet Çalgı", Profession = "Famous Note Player", FunFact = "Always plays the wrong note, but very fun" },
            new Musician { Id = 2, Name = "Zeynep Melodi", Profession = "Popular Melody Writer", FunFact = "Her songs are often misunderstood but very popular" },
            new Musician { Id = 3, Name = "Cemil Akor", Profession = "Crazy Accordist", FunFact = "Changes chords frequently, but is surprisingly talented" },
            new Musician { Id = 4, Name = "Fatma Nota", Profession = "Surprise Note Generator", FunFact = "Always prepares surprises while producing notes" },
            new Musician { Id = 5, Name = "Hasan Ritim", Profession = "Rhythm Monster", FunFact = "He does every beat in his own way, it doesn't fit at all but it's funny" },
            new Musician { Id = 6, Name = "Elif Armoni", Profession = "Master of Harmony", FunFact = "Sometimes she plays his harmonies wrong, but he's very creative" }

        };

        [HttpGet]
        public ActionResult<IEnumerable<Musician>> GetAll()
        {
            return Ok(_musicians);
        }

        [HttpGet("{id:int:min(1)}")]
        public ActionResult<Musician> GetMusician(int id)
        {
            var musician = _musicians.FirstOrDefault(x => x.Id == id);
            if (musician == null)
                return NotFound($"Musician with Id {id} not found");
            return Ok(musician);
        }

        [HttpGet("search")]
        public ActionResult<IEnumerable<Musician>> SearchMusicians([FromQuery] string profession)
        {
            var results = _musicians.Where(x => x.Profession.Contains(profession, StringComparison.OrdinalIgnoreCase));
            if (!results.Any())
                return NotFound($"No musicians found for profession: {profession}");
            return Ok(results);
        }

        [HttpPost]
        public ActionResult<Musician> Create([FromBody] Musician musician)
        {
            musician.Id = _musicians.Max(x => x.Id) + 1;
            _musicians.Add(musician);
            return CreatedAtAction(nameof(GetMusician), new { id = musician.Id }, musician);
        }

        [HttpPut("{id:int:min(1)}")]
        public IActionResult Update(int id, [FromBody] Musician updatedMusician)
        {
            var musician = _musicians.FirstOrDefault(x => x.Id == id);
            if (musician == null)
                return NotFound($"Musician with Id {id} not found");

            musician.Name = updatedMusician.Name;
            musician.Profession = updatedMusician.Profession;
            musician.FunFact = updatedMusician.FunFact;
            return NoContent();
        }

        [HttpPatch("{id:int:min(1)}")]
        public IActionResult UpdateFunFact(int id, [FromBody] JsonPatchDocument<Musician> patchDocument)
        {
            var musician = _musicians.FirstOrDefault(x => x.Id == id);
            if (musician == null)
                return NotFound($"Musician with Id {id} not found");

            patchDocument.ApplyTo(musician);
            return NoContent();
        }

        [HttpDelete("{id:int:min(1)}")]
        public IActionResult Delete(int id)
        {
            var musician = _musicians.FirstOrDefault(x => x.Id == id);
            if (musician == null)
                return NotFound($"Musician with Id {id} not found");

            _musicians.Remove(musician);
            return NoContent();
        }
    }

}

