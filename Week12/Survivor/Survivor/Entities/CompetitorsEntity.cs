using System.ComponentModel.DataAnnotations.Schema;

namespace Survivor.Entities
{
    public class CompetitorsEntity:BaseEntitiy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public CategoryEntity Category { get; set; }
    }
}
