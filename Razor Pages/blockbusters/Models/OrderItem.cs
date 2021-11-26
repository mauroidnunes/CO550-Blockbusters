using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class OrderItem
    {
        [Required]
        [DataType(DataType.Currency)]
        public decimal SalePrice { get; set; }
    }
}
