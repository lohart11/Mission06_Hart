using System.ComponentModel.DataAnnotations;

namespace Mission06_Hart.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        public string Subcategory { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        public string Rating { get; set; }

        public bool? Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }
    }
}

