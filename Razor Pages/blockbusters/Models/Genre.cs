using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blockbusters.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }

        // FOREIGN KEY REFRENCES
        [ForeignKey("GenreID")]
        public ICollection<Movie> Movie { get; set; }

        [ForeignKey("GenreID")]
        public ICollection<PersonGenre> PersonGenre { get; set; }
    }

    public enum GenreEnum
    {
        Action, Adventure, Comedy, Mystery, Fantasy, Fiction, Horror, Romance, Satire, SciFi, Thriller, Western
    }
}
