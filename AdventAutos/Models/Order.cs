using System;

namespace AdventAuto.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int StatusID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
