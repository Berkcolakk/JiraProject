using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestProject.DAL.Entities;
using TestProject.Services.UserServices;

namespace TestProject.API.Controllers.Users
{
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

        [HttpPost]
        [Route("/[controller]/Login")]
        [Produces("application/json")]
        public async Task<IActionResult> Login(User user)
        {
            return Ok(await userService.GetLoginUser(user));
        }


        [HttpPost]
        [Route("/[controller]/AddUser")]
        [Produces("application/json")]
        public async Task<IActionResult> AddUser(User user)
        {
            await userService.AddUser(user);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/UpdateUser")]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUser(User user)
        {
            await userService.UpdateUser(user);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/Delete")]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await userService.DeleteUser(id);
            return Ok();
        }
    }
}
