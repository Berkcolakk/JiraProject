using JiraProject.DAL.Entities;
using JiraProject.Services.UserTokenServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JiraProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly IUserTokenService userTokenService;
        public BaseController(IUserTokenService userTokenService)
        {
            this.userTokenService = userTokenService;
        }
        public async Task<UserToken> GetUserToken()
        {
            if (!string.IsNullOrEmpty(Request.Headers["Authorization"]))
            {
                string token = Request.Headers["Authorization"];
                UserToken userToken = await userTokenService.CheckTokenByUserToken(token);
                return userToken;
            }
            else
            {
                return null;
            }
        }
    }
}
