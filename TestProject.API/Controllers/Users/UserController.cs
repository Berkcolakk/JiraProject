using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestProject.DAL.Entities;
using TestProject.Services.UserServices;

namespace TestProject.API.Controllers.Users
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService _userService)
        {
            userService = _userService;
        }
        [HttpGet]
        [Route("/[controller]/GetAllUsers")]
        [Produces("application/json")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await userService.GetAllUsers());
        }
        [HttpGet]
        [Route("/[controller]/GetUserById/{id}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetUser(int id)
        {
            return Ok(await userService.GetUserById(id));
        }
        /// <summary>
        /// Example response
        /// {"Token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjAiLCJuYmYiOjE2NTEzMzExNzMsImV4cCI6MTY1MTkzNTk3MywiaWF0IjoxNjUxMzMxMTczfQ.mcY6X5o4OMY8E3GTQbuXJQsgrFuyQNXPim_EWWgR_Xw","ExpireDate": "0001-01-01T00:00:00"}
        /// </summary>
        /// <param name="user"></param>
        [AllowAnonymous]
        [HttpPost]
        [Route("/[controller]/Login")]
        [Produces("application/json")]
        public async Task<IActionResult> Login(User user)
        {
            return Ok(await userService.UserAuthentication(user));
        }
        [HttpPost]
        [Route("/[controller]/AddUser")]
        [Produces("application/json")]
        public async Task<IActionResult> AddUser(User user)
        {
            return Ok(await userService.AddUser(user));
        }
        [HttpPost]
        [Route("/[controller]/UpdateUser")]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUser(User user)
        {
            return Ok(await userService.UpdateUser(user));
        }
        [HttpPost]
        [Route("/[controller]/Delete")]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            return Ok(await userService.DeleteUser(id));
        }
    }
}
