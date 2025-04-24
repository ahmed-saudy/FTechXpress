using System.ComponentModel.DataAnnotations.Schema;

namespace FTechXpress.Models
{
    public class WishList
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Product> Products { get; set; }=new List<Product>();
    }
}
