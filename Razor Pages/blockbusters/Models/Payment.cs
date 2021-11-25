using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class Payment
    {
        [Key]
        public int ID { get; set; }
        public string CardholderName { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string CCV { get; set; }
        public string BillingAddress { get; set; }
    }
}
