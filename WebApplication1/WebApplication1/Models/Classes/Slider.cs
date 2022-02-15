using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Classes
{
    public class Slider
    {

        [Key]

        public int Id { get; set; }

        /* Slider */

        public string pic { get; set; }
        public string header { get; set; }

        public string firstslider { get; set; }


    }
}
