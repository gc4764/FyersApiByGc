

using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("/api/user")]
    public class UserController : ControllerBase
    {
        [HttpPost("register")]
        public object Register()
        {
            return new { name = "Guddu Chauhan", mob = 9451004764 };
        }

        [HttpGet("login")]
        public object Login()
        {
            return new { name = "Guddu Chauhan", mob = 9451004764,  };
        }

    

        [HttpDelete("logout")]
        public object CancellTrade()
        {
            return new { name = "Guddu Chauhan", mob = 9451004764 };
        }

        [HttpPatch("changePassword")]
        public object UpdateTrade()
        {
            return new { name = "Guddu Chauhan", mob = 9451004764 };
        }


    }
}
