using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; } = false;
    }
}
