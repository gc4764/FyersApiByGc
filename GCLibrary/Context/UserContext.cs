using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary.Context
{
    public class UserContext : IUserContext
    {
        public string UserName { get; set; } = string.Empty;
        public string EmailId { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
