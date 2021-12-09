using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blockbusters.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Sale Price")]
        [Column(TypeName = "money")]
        public decimal SalePrice { get; set; }

        // NAVIGATION PROPERTIES
        public virtual Order Order { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
