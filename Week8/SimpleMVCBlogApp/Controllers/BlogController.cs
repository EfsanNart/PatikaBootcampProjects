using Microsoft.AspNetCore.Mvc;
using SimpleMVCBlogApp.Models;

namespace SimpleMVCBlogApp.Controllers
{
    public class BlogController : Controller
    {
        private static int _nextId = 1;
        private static List<BlogPost> _posts = new List<BlogPost>();
        public IActionResult Index()
        {
            ViewBag.TotalPosts=_posts.Count;
            ViewData["PageTitle"] = "Blog gönderileri";
            return View(_posts);
        }
        public IActionResult Create()
        {
            //ViewBag, verileri Controller’dan View’e iletmek için tasarlanan dinamik bir nesnedir
            ViewBag.CurrentTime = DateTime.Now;
            return View();
        }
        [HttpPost]
        public IActionResult Create(BlogPost blogPost)
        {
            if (ModelState.IsValid)
            {
                blogPost.Id = _nextId++;
                _posts.Add(blogPost);
                TempData["SuccessMessage"] = "Blog gönderisi başarı ile oluşturuldu";
                return RedirectToAction("Index");
            }
            ViewBag.CurrentTime = DateTime.Now;
            return View(blogPost);
        }
        public IActionResult Details(int id)
        {
            var post= _posts.FirstOrDefault(x => x.Id == id);
            if (post is null)
            {
                return NotFound();
            }
            ViewData["CreatedAgo"]=$"{(DateTime.Now - post.CreatedAt).TotalMinutes} dakika önce"; 
            return View(post);
        }
    }
}
