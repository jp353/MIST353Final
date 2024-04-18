using Microsoft.AspNetCore.Mvc;
using MIST353FinalAPI.Entities;
using MIST353FinalAPI.Repositories;
using MIST353FinalAPI.Entities;
using System.Threading.Tasks;

namespace MIST353FinalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public FeedbackController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpPost("LeaveFeedback")]
        public async Task<IActionResult> LeaveFeedback(Rating rating)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var addedRating = await _ratingService.AddRating(rating);

            if (addedRating != null)
            {
                // Successfully added rating
                return CreatedAtAction(nameof(LeaveFeedback), new { id = addedRating.RID }, addedRating);
            }
            else
            {
                // Failed to add rating
                return StatusCode(500, "Failed to add rating.");
            }
        }
    }
}