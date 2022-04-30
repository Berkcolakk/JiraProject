using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Dto.User.Auth
{
    public class TokenDTO
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
        public Error.Error Error { get; set; }
    }
}
