using System.ComponentModel.DataAnnotations;

namespace Lunnax_Packages.Models
{
    public class PeriodDto
    {
        public int Id { get; set; }

        [Required]
        public DateTime? Start { get; set; }

        [Required]
        public DateTime? End { get; set; }

        [Required]
        public string? Source { get; set; }

        [Required]
        public int SourceId { get; set; }

        [Required]
        [MinPrice(ErrorMessage = "price must be greater than 0")]
        public decimal Price { get; set; }

    }
}
