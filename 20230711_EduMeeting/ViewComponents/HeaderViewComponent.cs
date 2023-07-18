using _20230711_EduMeeting.Models;
using _20230711_EduMeeting.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _20230711_EduMeeting.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        DataContext db;
        public HeaderViewComponent(DataContext _db)
        {
            db= _db;
        }

        public IViewComponentResult Invoke()
        {
            HeaderVM headerVM=new HeaderVM()
            {
                Categories=db.Category.OrderBy(x => x.DisplayIndex),
                SocailMedia=db.SocailMedia.FirstOrDefault(),
            };
            return View(headerVM);
        }
    }
}
