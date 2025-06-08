using Microsoft.AspNetCore.Mvc;
using TesteCi.Services.Domain.Interfaces;

namespace TesteCi.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase
    {
        private readonly IMathService _mathService;

        public MathController(IMathService mathService)
        {
            _mathService = mathService;
        }

        [HttpGet("double/{number}")]
        public ActionResult<int> GetDouble(int number)
        {
            return Ok(_mathService.GetDouble(number));
        }
    }
}
