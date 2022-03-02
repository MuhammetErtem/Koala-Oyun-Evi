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
                

            };
            return View(indexVM);
        }
    }
}
