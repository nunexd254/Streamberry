using Microsoft.AspNetCore.Mvc;
using Streamberry.Models;

namespace Streamberry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssessmentController : Controller
    {
        private readonly IAssRepository _assRepository;

        public AssController(IAssRepository assRepository)
        {
            _assRepository = assRepository;
        }

        [HttpPost("addAssessment")]
        public async Task<ActionResult<AssessmentModel>> AddAssessment([FromBody] AssessmentModel assModel, string titleMovie)
        {
            AssessmentModel ass = await _assRepository.AddAssessment(assModel, titleMovie);
            return Ok(ass);
        }

        [HttpPut("updateAssessment")]
        public async Task<ActionResult<AssessmentModel>> UpdateAssessment([FromBody] AssessmentModel assModel, int id)
        {
            assModel.Id = id;
            AssModel ass = await _assRepository.UpdateAssessment(assModel, id);
            return Ok(ass);
        }

        [HttpDelete("deleteAssessment")]
        public async Task<ActionResult<AssessmentModel>> DeleteAssessment(int id)
        {
            bool assDeleted = await _assRepository.DeleteAssessment(id);
            return Ok(assDeleted);
        }

        [HttpGet("assessments")]
        public async Task<ActionResult<List<AssessmentModel>>> SearchAllAss()
        {
            List<AssessmentModel> ass = await _assRepository.SearchAllAss();
            return Ok(ass);
        }

        [HttpGet("searchAssMovie")]
        public async Task<ActionResult<List<AssessmentModel>>> SearchAssMovie(string title)
        {
            List<AssessmentModel> assMovie = await _assRepository.SearchAssMovie(title);
            return Ok(assMovie);
        }
    }
}
