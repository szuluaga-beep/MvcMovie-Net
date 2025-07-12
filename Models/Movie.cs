using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = null!;

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required(ErrorMessage = "Genre is required")]
        [StringLength(30, MinimumLength = 3)]
        public string Genre { get; set; } = null!;

        [DataType(DataType.Currency)]
        [Range(1, 100, ErrorMessage = "Price must be between 1 and 100")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "Movie Rating")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; } = null!;
    }
}