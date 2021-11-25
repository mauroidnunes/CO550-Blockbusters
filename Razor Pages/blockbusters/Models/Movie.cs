using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public string LeadingDirector { get; set; }
        public string LeadingProducer { get; set; }
        public string ContentLocation { get; set; }
        public decimal Price { get; set; }

    }
}
