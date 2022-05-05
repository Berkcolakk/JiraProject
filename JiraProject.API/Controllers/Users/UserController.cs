using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using JiraProject.API.Helpers;
using JiraProject.DAL.Entities;
using JiraProject.Services.UserServices;

namespace JiraProject.API.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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
        /// {"Token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYmYiOjE2NTE3NzI4NzUsImV4cCI6MTY1MjM3NzY3NSwiaWF0IjoxNjUxNzcyODc1fQ.lHA-Y16XUyuhwmHUmESoBKC-T5kJ5qh79rQP3vwLM9s","ExpireDate": "12.05.2022 17:47:55","Error": null}
        /// </summary>
        /// <param name="user" >User object</param>
        [HttpPut]
        [Route("/[controller]/Login")]
        [Produces("application/json")]
        [AllowAnonymous]
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
        [HttpPut]
        [Route("/[controller]/UpdateUser")]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUser(User user)
        {
            return Ok(await userService.UpdateUser(user));
        }
        [HttpDelete]
        [Route("/[controller]/Delete")]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            return Ok(await userService.DeleteUser(id));
        }
    }
}