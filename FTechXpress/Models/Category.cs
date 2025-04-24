using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FTechXpress.Models
{
    public class Category
    {
        //[Display(Name = "Category Name")]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; } = new List<Product>();

    }
}
