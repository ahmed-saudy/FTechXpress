namespace FTechXpress.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime DateTime { get; set; }
        public virtual User user { get; set; }
        public virtual List<Product>? ProductsInOrder { get; set; }
    }
}
