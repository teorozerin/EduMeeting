using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20230711_EduMeeting.Models
{
    public class Meeting
    {
        //[key]
        //public int IlanNo { get; set; }
        public int ID { get; set; }

        [Column (TypeName = "varchar(50)"),Required(ErrorMessage ="meeting adı boş bırakılamaz"),Display(Name="Meeting Adı"),StringLength(50,ErrorMessage ="en fazla 50 karakter girilebilir")]
        public string Name { get; set; }//-------------------

        [Column(TypeName ="Varchar(100)")]
        public string Description { get; set; }//-----------------

        [Column(TypeName = "Varchar(150)")]
        public string Picture { get; set; }//-----------------

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public DateTime RecDate { get; set;}
        public int DisplayIndex { get; set;}

        //-----------------------------------
        public int? CategoryID { get; set; }
        public Category Category { get; set; }

        [Column(TypeName ="Text")]
        public string Detail { get; set; }
    }
}
