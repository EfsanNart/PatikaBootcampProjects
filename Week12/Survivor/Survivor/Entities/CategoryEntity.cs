namespace Survivor.Entities
{
    public class CategoryEntity:BaseEntitiy
    {
        public string Name { get; set; }
        public ICollection<CompetitorsEntity> Competitors { get; set; }
    }
}
