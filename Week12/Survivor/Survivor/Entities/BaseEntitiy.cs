using System.ComponentModel.DataAnnotations;

namespace Survivor.Entities
{
    public class BaseEntitiy
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
