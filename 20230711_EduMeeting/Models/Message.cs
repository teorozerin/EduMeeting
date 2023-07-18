using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20230711_EduMeeting.Models
{
    public class Message
    {
        public int ID { get; set; }
        [Column(TypeName="Varchar(50)"),Display(Name="Adı Soyadı"),StringLength(50)]
        public string NameUserName { get; set; }//--------------------------------------------

        [Column(TypeName = "Varchar(80)"), Display(Name = "Mail Adresi"), StringLength(50)]
        public string MailAdress { get; set; }//--------------------------------------------

        [Column(TypeName = "Varchar(100)"), Display(Name = "Konu"), StringLength(50)]
        public string Subject { get; set; }//--------------------------------------------

        [Column(TypeName = "Varchar(500)"), Display(Name = "Mesaj"), StringLength(50)]
        public string Messages { get; set; }//--------------------------------------------

        [ Display(Name = "Kayıt Tarihi")]
        public DateTime RecTime { get; set; }//--------------------------------------------

        [Display(Name = "IP Adresi")]
        public string IPNO { get; set;}
    }
}
