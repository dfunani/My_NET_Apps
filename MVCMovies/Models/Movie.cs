using System.ComponentModel.DataAnnotations;

namespace MVCMovies.Models
{
    public class Movie
    {
        public int Id { get; set; } = default(int);
        public string? Title { get; set; } = default(string);
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } = default;
        public string? Genre{ get; set; } = default;
        public decimal Price { get; set; } = default;
    }
}
