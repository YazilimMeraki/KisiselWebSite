using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Classes
{
    public class Homepage
    {
        [Key]

        public int Id { get; set; }

        /* Sayfa adı ve ünvan */
        public string PageName { get; set; }

       
        /* Hakkımda */

        public string AboutMe { get; set; }


    }
}