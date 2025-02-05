using System.ComponentModel.DataAnnotations;

namespace SimpleMVCBlogApp.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Başlık gereklidir")]
        [StringLength(100,ErrorMessage ="100 karakterden fazla olamaz.")]
        public string Title { get; set; }
        [Required(ErrorMessage ="İçerik gereklidir")]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }=DateTime.Now;
    }
}
