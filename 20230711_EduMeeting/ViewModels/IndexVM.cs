using _20230711_EduMeeting.Models;

namespace _20230711_EduMeeting.ViewModels
{
    public class IndexVM
    {
        public IEnumerable  <Category> Categories{ get; set; }
        public IEnumerable<Meeting> Meetings { get; set; } 
        public IEnumerable<Education> Educations { get; set; }
        public Message Message { get; set; } 
    }
}
