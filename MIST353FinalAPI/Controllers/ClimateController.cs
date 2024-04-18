using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MIST353FinalAPI.Entities;
using Microsoft.Extensions.Hosting;
using MIST353FinalAPI.Repositories;
using System;
namespace MIST353FinalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IClimateService _climateService;

        public RegionController(IClimateService climateService)
        {
            _climateService = climateService;
        }

        [HttpGet("{RNum}")]
        public async Task<ActionResult<List<Climate_Event>>> GetClimateEvents(int RNum)
        {
            var climateEventDetails = await _climateService.GetClimateEvents(RNum);
            return climateEventDetails;
        }
    }
}


// ClimateContoller, FeedbackController, ClimateService, RatingService, and their interfaces were created by John Pino