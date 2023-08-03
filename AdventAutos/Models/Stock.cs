using System.ComponentModel.DataAnnotations;

namespace AdventAuto.Models
{
    public class Stock
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int ProductCategory { get; set; }
    }
}
