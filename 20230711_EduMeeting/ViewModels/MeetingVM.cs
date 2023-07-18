using _20230711_EduMeeting.Models;

namespace _20230711_EduMeeting.ViewModels
{
    public class MeetingVM
    {
        public IEnumerable<Meeting> Meetings { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
