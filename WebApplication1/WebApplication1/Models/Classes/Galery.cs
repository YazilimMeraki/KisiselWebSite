using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Classes
{
    public class Galery
    {

        [Key]

        public int Id { get; set; }

        /* Slider */

        public string pic { get; set; }
        public string header { get; set; }
    }
}