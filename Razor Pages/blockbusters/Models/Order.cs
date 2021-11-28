using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blockbusters.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; } = false;

        // FOREIGN KEYS
        public int PersonID { get; set; }
        public Person Person { get; set; }

        // FOREIGN KEY REFRENCES
        [ForeignKey("OrderID")]
        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
