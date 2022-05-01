using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestProject.DAL.Entities;
using TestProject.Services.UserRoleServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProject.API.Controllers.UserRoles
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleService userRoleService;

        public UserRoleController(IUserRoleService _userRoleService)
        {
            userRoleService = _userRoleService;
        }

        [HttpGet]
        [Route("/[controller]/GetAllUserRoles")]
        [Produces("application/json")]
        public async Task<IActionResult> GetAllUserRoles()
        {
            return Ok(await userRoleService.GetAllUserRoles());
        }

        [HttpGet]
        [Route("/[controller]/GetUserRoleById/{id}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetUserRoleById(int id)
        {
            return Ok(await userRoleService.GetUserRoleById(id));
        }

        [HttpPost]
        [Route("/[controller]/AddUserRole")]
        [Produces("application/json")]
        public async Task<IActionResult> AddUserRole(UserRole userRole)
        {
            await userRoleService.AddUserRole(userRole);
            return Ok();
        }

        [HttpPut]
        [Route("/[controller]/UpdateUserRole")]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUserRole(UserRole userRole)
        {
            await userRoleService.UpdateUserRole(userRole);
            return Ok();
        }

        [HttpDelete]
        [Route("/[controller]/DeleteUserRole")]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteUserRole(int id)
        {
            await userRoleService.DeleteUserRole(id);
            return Ok();
        }
    }
}