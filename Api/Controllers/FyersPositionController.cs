

using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("/fyers/Trade")]
    public class FyersPositionController : ControllerBase
    {
        [HttpGet("")]
        public object GetTrades()
        {
            return new { name = "Guddu Chauhan", mob = 9451004764 };
        }

        [HttpGet("{id}")]
        public object GetTradeById(int id)
        {
            return new { name = "Guddu Chauhan", mob = 9451004764, ID=id };
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
