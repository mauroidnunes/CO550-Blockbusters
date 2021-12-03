using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blockbusters.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Required(ErrorMessage = "Cardholder Name is required")]
        [RegularExpression(@"^.{2,}$", ErrorMessage = "Minimum 2 characters required")]
        [StringLength(20, ErrorMessage = "Maximum 26 characters exceeded")]
        public string CardholderName { get; set; }

        [Required(ErrorMessage = "Card Number is required")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Card Number must be numeric")]
        [StringLength(16, ErrorMessage = "Card Number must be 16 digits", MinimumLength = 16)]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Expiration Date is required")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Expiration Date must be numeric")]
        [StringLength(4, ErrorMessage = "Expiration Date must be 4 digits", MinimumLength = 4)]
        public string ExpirationDate { get; set; }

        [Required(ErrorMessage = "CCV is required")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "CCV must be numeric")]
        [StringLength(3, ErrorMessage = "CCV must be 3 digits", MinimumLength = 3)]
        public string CCV { get; set; }
    }
}