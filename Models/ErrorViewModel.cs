using System.ComponentModel.DataAnnotations;

namespace Mission06_Hart.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string RentTo { get; set; }
        public string Notes { get; set; }
    }
}
