using Koala.DAL.DbContexts;
using Koala.WEBUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Koala.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        SqlContext db;
        public HomeController(SqlContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            IndexVm indexVM = new IndexVm
            {
                Slider = db.Slider,
                GalleryPicture = db.GalleryPicture.OrderByDescending(o => o.ID).Take(5),
                People = db.People.OrderByDescending(o => o.ID).Take(3),

            };   
            return View(indexVM);
        }
    }
}
