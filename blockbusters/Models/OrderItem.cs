using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal SalePrice { get; set; }

        // NAVIGATION PROPERTIES
        public virtual Order Order { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
