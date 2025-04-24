using System.ComponentModel.DataAnnotations;

namespace FTechXpress.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        [Required]
        public int Rating { get; set; }
        public DateTime DateTime { get; set; }
        public virtual User User { get; set; }
        public virtual Product product { get; set; }

    }
}
