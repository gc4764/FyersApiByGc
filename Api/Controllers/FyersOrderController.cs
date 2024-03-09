

using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("/fyers/Trade")]
    public class FyersOrderController : ControllerBase

    {
        [HttpGet("")]
        public IActionResult GetTrades([FromBody] int id, [FromHeader] string user_id)
        {
            var data = new { name = "Guddu Chauhan", mob = 9451004764 };
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult GetTradeById(int id)
        {
            var data = new { name = "Guddu Chauhan", mob = 9451004764, ID = id };
            return Ok(data);
        }

        [HttpPost("")]
        public object PostTrade()
        {
            return new { name = "Guddu Chauhan", mob = 9451004764 };
        }

        [HttpDelete("")]
        public object CancellTrade()
        {
            return new { name = "Guddu Chauhan", mob = 9451004764 };
        }

        [HttpPatch("")]
        public object UpdateTrade()
        {
            return new { name = "Guddu Chauhan", mob = 9451004764 };
        }


    }
}
