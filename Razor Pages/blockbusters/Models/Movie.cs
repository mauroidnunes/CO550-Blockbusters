using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [RegularExpression(@"^.{2,}$", ErrorMessage = "Minimum 2 characters required")]
        [StringLength(255, ErrorMessage = "Maximum 255 characters exceeded")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [RegularExpression(@"^.{8,}$", ErrorMessage = "Minimum 8 characters required")]
        [StringLength(255, ErrorMessage = "Maximum 255 characters exceeded")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [DataType(DataType.Date)]
        public DateOnly ReleaseDate { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [RegularExpression(@"^.{2,}$", ErrorMessage = "Minimum 2 characters required")]
        [StringLength(50, ErrorMessage = "Maximum 50 characters exceeded")]
        public string LeadingDirector { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [RegularExpression(@"^.{2,}$", ErrorMessage = "Minimum 2 characters required")]
        [StringLength(50, ErrorMessage = "Maximum 50 characters exceeded")]
        public string LeadingProducer { get; set; }

        public string ContentLocation { get; set; } = "/baseimagelocation/example.jpg";

        [Required(ErrorMessage = "Field is required")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

    }
}
