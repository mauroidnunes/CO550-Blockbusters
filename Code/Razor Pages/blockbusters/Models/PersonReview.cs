using System;
using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class PersonReview
    {
        [Key]
        public int PersonReviewID { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Review Date")]
        public DateTime ReviewDate { get; set; }

        [Required]
        [RegularExpression(@"^.{1,}$", ErrorMessage = "Minimum 1 character required")]
        [StringLength(255, ErrorMessage = "Maximum 255 characters exceeded")]
        [Display(Name = "Review Text")]
        public string ReviewText { get; set; }

        public int Likes { get; set; } = 0;

        // NAVIGATION PROPERTIES
        public virtual Movie Movie { get; set; }

        public virtual Person Person { get; set; }
    }
}
