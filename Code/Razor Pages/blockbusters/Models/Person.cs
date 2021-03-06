using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blockbusters.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        public int PaymentID { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress), StringLength(90)]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Username is required")]
        //[RegularExpression(@"^.{4,}$", ErrorMessage = "Minimum 4 characters required")]
        //[StringLength(20, ErrorMessage = "Maximum 20 characters exceeded")]
        //public string Username { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression(@"^.{2,}$", ErrorMessage = "Minimum 2 characters required")]
        [StringLength(50, ErrorMessage = "Maximum 50 characters exceeded")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [RegularExpression(@"^.{2,}$", ErrorMessage = "Minimum 2 characters required")]
        [StringLength(30, ErrorMessage = "Maximum 30 characters exceeded")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Staff Account")]
        public bool StaffAccount { get; set; } = false;

        // NAVIGATION PROPERTIES
        public virtual Payment Payment { get; set; }

        //
        public virtual ICollection<Order> Order { get; set; }

        public virtual ICollection<PersonReview> PersonReviews { get; set; }

        public virtual ICollection<PersonGenre> PersonGenres { get; set; }
    }
}
