using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Streamberry.Models
{
    public class AssessmentModel
    {
        [Key, Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required int Note { get; set; }

        public string? Comment { get; set; }

        public string? MovieTitle { get; set; }

        public virtual MovieModel? Movie { get; set; }
    }
}
