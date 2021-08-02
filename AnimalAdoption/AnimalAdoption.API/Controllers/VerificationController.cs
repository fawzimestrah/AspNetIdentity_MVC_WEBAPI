using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VerificationController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> Verify([FromQuery] string phoneNumber)
        {
            return Ok();
        }


    }
}
