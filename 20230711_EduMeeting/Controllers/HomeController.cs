using _20230711_EduMeeting.Models;
using _20230711_EduMeeting.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _20230711_EduMeeting.Controllers
{
    public class HomeController : Controller
    {
        DataContext db;
        public HomeController(DataContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            IndexVM indexVM = new IndexVM()
            {
                Categories=db.Category.OrderBy( x => x.DisplayIndex ),
                Meetings=db.Meeting.OrderBy( x => x.DisplayIndex ),
                Educations=db.Education.OrderBy( x => x.DisplayIndex ),
            };

            ViewBag.MenuIndex = 0;
            return View(indexVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Message(IndexVM model)
        {
            model.Message.RecTime = DateTime.Now;
            model.Message.IPNO=Request.HttpContext.Connection.RemoteIpAddress.ToString();
            db.Message.Add(model.Message);
            db.SaveChanges();

            TempData["adsoyad"] = model.Message.NameUserName;
            return RedirectToAction("Index");
        }
    }
}
