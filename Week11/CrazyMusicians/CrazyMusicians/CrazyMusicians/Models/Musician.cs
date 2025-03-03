using System.ComponentModel.DataAnnotations;

namespace CrazyMusicians.Models
{
    public class Musician
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Profession { get; set; }
        public string FunFact { get; set; }
    }
}
