using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetAllUsers()
        {
            return Ok(userService.GetAllUsers());
        }

        [HttpGet]
        [Route("/[controller]/GetUserById/{id}")]
        [Produces("application/json")]
        public IActionResult GetUser(int id)
        {
            return Ok(userService.GetUserById(id));
        }

        [HttpPost]
        [Route("/[controller]/AddUser")]
        [Produces("application/json")]
        public IActionResult AddUser(User user)
        {
            userService.AddUser(user);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/UpdateUser")]
        [Produces("application/json")]
        public IActionResult UpdateUser(User user)
        {
            userService.UpdateUser(user);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/Delete")]
        [Produces("application/json")]
        public IActionResult DeleteUser(int id)
        {
            userService.DeleteUser(id);
            return Ok();
        }
    }
}
