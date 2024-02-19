using Streamberry.Enumeration;

namespace Streamberry.Helper
{
    public class MovieMediaAssHelperVO
    {
        public required string Title { get; set; }
        public required GenderEnum Gender { get; set; }
        public required int MonthMovie { get; set; }
        public required int YearMovie { get; set; }
        public float? MediaAss { get; set; }
        public required bool MovieAss { get; set; }
    }
}
