using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20230711_EduMeeting.Models
{
    public class Education
    {
        public int ID { get; set; }
        [Column(TypeName ="Varchar(50)"),Required(ErrorMessage ="Eğitim Adı Boş Bırakılamaz"),Display(Name="Eğitim adı"),StringLength(50,ErrorMessage ="en fazla 50 karakter girilebilir")]
        public string Name { get; set; }
        [Column(TypeName ="Varchar(50)")]
        public string Picture { get; set; }

        public int DisplayIndex { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        public int Star { get; set; }
    }
}
