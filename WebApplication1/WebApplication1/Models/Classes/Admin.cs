using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Classes
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string pwd { get; set; }
    }
}