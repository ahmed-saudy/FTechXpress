using System.ComponentModel.DataAnnotations;

namespace FTechXpress.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MinLength(11)]
        [MaxLength(13)]
        public string PhoneNumber { get; set; }
        [Required]
        [MinLength(10)]
        public string Address { get; set; }

        public string Color { get; set; }
    }
}
