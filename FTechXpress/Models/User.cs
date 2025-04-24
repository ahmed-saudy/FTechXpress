using System.ComponentModel.DataAnnotations;

namespace FTechXpress.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
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
        public string Role { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual WishList WishList { get; set; }
        public virtual List<Review> Reviews { get; set; }=new List<Review>();
       
    }

}
