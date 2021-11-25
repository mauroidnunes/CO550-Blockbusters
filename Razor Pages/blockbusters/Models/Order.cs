using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public string OrderDate { get; set; }
        public bool OrderStatus { get; set; }
    }
}
