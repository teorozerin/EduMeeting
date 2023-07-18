namespace _20230711_EduMeeting.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DisplayIndex { get; set; }

        //---------------------------------------------------------
        public ICollection<Meeting>Meetings { get; set; }
    }
}
