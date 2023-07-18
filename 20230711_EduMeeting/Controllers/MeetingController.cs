using _20230711_EduMeeting.Models;
using _20230711_EduMeeting.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _20230711_EduMeeting.Controllers
{
    public class MeetingController : Controller
    {
        DataContext db;
        public MeetingController(DataContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            MeetingVM meetingVM = new MeetingVM()
            {
                Meetings=db.Meeting.OrderBy(x=>x.DisplayIndex),
                Categories=db.Category.OrderBy(x => x.DisplayIndex)
            };
            ViewBag.MenuIndex = 1;
            return View(meetingVM);
        }

        //[Route("/toplanti/detay")]
        //[Route("/toplanti/detay/{name}")]
        [Route("/toplanti/detay/{name}/{id}")]
        public IActionResult Detail(string name,int id) 
        {

            ViewBag.MenuIndex = 1;
            return View(db.Meeting.First(x=>x.ID==id));
        }
    }
}
