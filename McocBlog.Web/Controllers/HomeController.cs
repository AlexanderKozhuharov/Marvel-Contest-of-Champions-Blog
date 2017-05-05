using System.Linq;
using System.Web.Mvc;
using McocBlog.Data;
using System.Data.Entity;

namespace McocBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        private McocBlogContext db = new McocBlogContext();
        public ActionResult Index()
        {
            var posts = db.Posts.Include(p => p.Author).OrderByDescending(p => p.Date).Take(3);

            return View(posts.ToList());
        }

        public ActionResult Home()
        {
            return View();
        }    
    }
}