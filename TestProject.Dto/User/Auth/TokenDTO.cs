using System;

namespace TestProject.Dto.User.Auth
{
    public class TokenDTO
    {
        public string Token { get; set; }

        public DateTime ExpireDate { get; set; }

        public Error.Error Error { get; set; }
    }
}