using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class OrderItem
    {
        // FOREIGN KEYS
        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int MovieID { get; set; }
        public Movie Movie { get; set; }
        // END OF FOREIGN KEYS

        [Required]
        [DataType(DataType.Currency)]
        public decimal SalePrice { get; set; }
    }
}
