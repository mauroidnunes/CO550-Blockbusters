using System;
using System.Collections.Generic;
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
        public bool Completed { get; set; } = false;

        // 
        public virtual Person Person { get; set; }

        // 
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
