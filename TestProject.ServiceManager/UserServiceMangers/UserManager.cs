using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TestProject.DAL.Context;
using TestProject.DAL.Entities;
using TestProject.Dto.User.Auth;

namespace TestProject.ServiceManager.UserServiceMangers
{
    public class UserManager
    {
        private readonly TestProjectContext context;
        private readonly IConfiguration config;
        public UserManager(TestProjectContext context, IConfiguration _config)
        {
            this.context = context;
            config = _config;
        }

        public async Task<TokenDTO> GetLoginUser(User user)
        {
            User appUser = await context.User.Where(x => x.Email == user.Email && x.Password == user.Password).SingleOrDefaultAsync();

            if (appUser != null)
            {
                var secret = config.GetSection("AppIdentitySettings:Password");
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(secret.Value);
                DateTime expireDate = DateTime.UtcNow.AddDays(7);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.ID.ToString())
                }),
                    Expires = expireDate,
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                string token = tokenHandler.WriteToken(securityToken);
                return new TokenDTO() { Token = token, ExpireDate = expireDate };
            }
            else
            {
                return new TokenDTO() { Error = new Dto.Error.Error() { ErrorMessage = "Wrong email or password." } };
            }
        }
    }
}
