using Streamberry.Enumeration;
using Streamberry.Helper;
using Streamberry.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;


namespace Streamberry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {

        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpPost("insertMovie")]
        public async Task<ActionResult<MovieModel>> InsertMovie([FromBody] MovieModel movieModel)
        {
            MovieModel movie = await _movieRepository.InsertMovie(movieModel);
            return Ok(movie);
        }

        [HttpPut("updateMovie")]
        public async Task<ActionResult<MovieModel>> UpdateMovie([FromBody] MovieModel movieModel, string title)
        {
            movieModel.Title = title;
            MovieModel movie = await _movieRepository.UpdateMovie(MovieModel, title);
            return Ok(movie);
        }

        [HttpDelete("deleteMovie")]
        public async Task<ActionResult<MovieModel>> DeleteMovie(string title)
        {
            bool movieWipedOut = await _movieRepository.DeleteMovie(title);
            return Ok(movieWipedOut);
        }

        [HttpGet("movies")]
        public async Task<ActionResult<List<MovieModel>>> SearchAllMovies()
        {
            List<MovieModel> movies = await _movieRepository.SearchAllMovies();
            return Ok(movies);
        }

        [HttpGet("searchForTitle")]
        public async Task<ActionResult<MovieModel>> searchForTitle(string title)
        {
            MovieModel moviesTitle = await _movieRepository.searchForTitle(title);
            return Ok(moviesTitle);
        }

        [HttpGet("SearchAssYearGender")] 
        public async Task<ActionResult<List<AssMovieHelperVO>>> SearchAssYear(int yearStart, int yearEnd, GenderEnum gender)
        {
            List<AssMovieHelperVO> assYear = await _movieRepository.SearchAssGenderYear(yearStart, yearEnd, gender);
            return Ok(assYear);
        }

        [HttpGet("SearchMovieForAss")] 
        public async Task<ActionResult<List<AssMovieHelperVO>>> SearchMovieForAss(int? note, string? comment)
        {
            List<AssMovieHelperVO> moviesForAss = await _movieRepository.SearchMovieForAss(note, comment);
            return Ok(moviesForAss);
        }

        [HttpGet("mediaAssMovie")]
        public async Task<ActionResult<float>> SearchMediaMovie(string title)
        {
            float mediaMovie = await _movieRepository.mediaAssMovie(title);

            return mediaMovie;
        }

        [HttpGet("mediaAssCatalog")]
        public async Task<ActionResult<List<MovieMediaAssHelperVO>>> SearchMediaAssCatalog()
        {
            List<MovieMediaAssHelperVO> mediaCatalog = await _movieRepository.MediaAssAllMovies();

            return mediaCatalog;
        }

        [HttpGet("mediaAssGenderYear")]
        public async Task<float> MediaAssGenderYear(GenderEnum gender, int yearStart, int yearEnd)
        {
            float mediaGenderYear = await _movieRepository.MediaAssGenderYear(gender, yearStart, yearEnd);
            return mediaGenderYear;
        }

        [HttpGet("moviesYear")]
        public async Task<ActionResult<List<MovieModel>>> MoviesYear(int year)
        {
            List<MovieModel> moviesYear = await _movieRepository.MoviesYear(year);
            return moviesYear;
        }

        [HttpGet("streamingMovie")]
        public async Task<ActionResult<List<string>>> StreamingsDispMovie(string title)
        {
            List<string> streamingsMovie = await _movieRepository.StreamingsDispMovie(title);
            return streamingsMovie;
        }

        [HttpGet("moviesNoStreaming")]
        public async Task<ActionResult<List<MovieModel>>> MoviesNoStreaming(string streaming)
        {
            List<MovieModel> moviesStreaming = await _movieRepository.MoviesNoStreaming(streaming);
            return moviesStreaming;
        }
    }
}