using System.ComponentModel.DataAnnotations;

namespace blockbusters.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
    }

    public enum GenreEnum
    {
        Action, Adventure, Comedy, Mystery, Fantasy, Fiction, Horror, Romance, Satire, SciFi, Thriller, Western
    }
}
