using Streamberry.Enumeration;

namespace Streamberry.Helper
{
    public class AssMovieHelperVO
    {
        public required int AssId { get; set; }
        public required string Title { get; set; }
        public required GenderEnum Gender { get; set; }
        public required int MonthMovie { get; set; }
        public required int YearMovie { get; set; }
        public List<String>? StreamingsAvailable { get; set; }
        public int Note { get; set; }
        public string? Comment { get; set; }
    }
}
