using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blockbusters.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [RegularExpression(@"^.{4,}$", ErrorMessage = "Minimum 4 characters required")]
        [StringLength(20, ErrorMessage = "Maximum 20 characters exceeded")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^.{8,}$", ErrorMessage = "Minimum 8 characters required")]
        [StringLength(20, ErrorMessage = "Maximum 128 characters exceeded")]
        public string Password { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression(@"^.{2,}$", ErrorMessage = "Minimum 2 characters required")]
        [StringLength(50, ErrorMessage = "Maximum 50 characters exceeded")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [RegularExpression(@"^.{2,}$", ErrorMessage = "Minimum 2 characters required")]
        [StringLength(50, ErrorMessage = "Maximum 50 characters exceeded")]
        public string LastName { get; set; }

        public bool StaffAccount { get; set; } = false;

        // FOREIGN KEYS
        public int PaymentID { get; set; }
        public Payment Payment { get; set; }

        // FOREIGN KEY REFRENCES
        [ForeignKey("PersonID")]
        public ICollection<Order> Order { get; set; }

        [ForeignKey("PersonID")]
        public ICollection<PersonReview> PersonReview { get; set; }

        [ForeignKey("PersonID")]
        public ICollection<PersonGenre> PersonGenre { get; set; }
    }
}
