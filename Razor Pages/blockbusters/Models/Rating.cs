using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class Rating
    {
        [Key]
        public int RatingID { get; set; }

        [Required]
        public int RatingScore { get; set; } = 0;
    }
}
