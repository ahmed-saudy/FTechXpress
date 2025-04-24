using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FTechXpress.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Name Required")]
        [MinLength (3,ErrorMessage ="Name Should be more than 3 char")]
       
        public string Name { get; set; }
        [Required(ErrorMessage = "Description Required")]
        [MinLength(10,ErrorMessage = "Name Should be more than 10 char")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price Required")]
        [Range(1, 9999999, ErrorMessage = "Stock Should be between 1 and 9999999")]
        public Decimal Price { get; set; }
        [Range(1, 500, ErrorMessage = "Stock Should be between 1 and 500")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "Category Required")]
        public virtual Category Category { get; set; } = new Category();
        public virtual List<Cart>? InCart { get; set; }=new List<Cart>();
        public virtual List<Order>? InOrder { get; set; } = new List<Order>();
        public virtual List<WishList?> InWishList { get; set; }=new List<WishList?>();
        public virtual List<Review?> Reviews { get; set; } = new List<Review?>();
    }
}
