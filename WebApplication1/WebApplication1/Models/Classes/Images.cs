using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Classes
{
    public class Images
    {
        [Key]

        public int Id { get; set; }

        /* Projeler */

        public string pic { get; set; }
        public string about { get; set; }
        public string header { get; set; }

    }
}