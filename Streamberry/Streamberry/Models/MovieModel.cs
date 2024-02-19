using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Streamberry.Models
{
    public class MovieModel
    {
        [Key, Column("Title")]
        public string? Title { get; set; }
        public required GenderEnum Gender { get; set; }
        public required int Month { get; set; }
        public required int Year { get; set; }
        public List<String>? StreamingsAvailable { get; set; }

    }
}
