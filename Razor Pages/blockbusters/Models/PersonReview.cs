using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class PersonReview
    {
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReviewDate { get; set; }

        [Required]
        [RegularExpression(@"^.{1,}$", ErrorMessage = "Minimum 1 character required")]
        [StringLength(255, ErrorMessage = "Maximum 255 characters exceeded")]
        public string ReviewText { get; set; }
    }
}
