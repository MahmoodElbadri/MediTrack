using Microsoft.AspNetCore.Mvc;

namespace MediTrack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Status = "Healthy" });
        }
    }
}
