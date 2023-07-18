namespace _20230711_EduMeeting.Tools
{
    public class GeneralTools
    {
        public static string LinkOlustur(string metin)
        {
            return metin.ToLower().Replace(" " , "-").Replace("ğ","g").Replace("ü","u").Replace("ş","s").Replace("ö","o").Replace("ç","c").Replace("ı","i").Replace("/","");
        }
    }
}
