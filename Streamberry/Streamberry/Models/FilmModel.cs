using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Streamberry.Models
{
    public class FilmModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? Year {  get; set; }

        [Display(Name = "Genero")]
        [Column("IdGenero")]
        [ForeignKey("GenderModel")]
        public Guid IdGenero { get; set; }
    }
}
