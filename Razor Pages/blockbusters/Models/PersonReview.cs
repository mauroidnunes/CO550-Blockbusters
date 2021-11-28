using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class PersonReview
    {
        // FOREIGN KEYS
        public int MovieID { get; set; }
        public Movie Movie { get; set; }

        public int PersonID { get; set; }
        public Person Person { get; set; }
        // END OF FOREIGN KEYS

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReviewDate { get; set; }

        [Required]
        [RegularExpression(@"^.{1,}$", ErrorMessage = "Minimum 1 character required")]
        [StringLength(255, ErrorMessage = "Maximum 255 characters exceeded")]
        public string ReviewText { get; set; }

        public int Likes { get; set; } = 0;
    }
}
