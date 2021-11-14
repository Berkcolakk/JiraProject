using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetAllUserRoles()
        {
            return Ok(userRoleService.GetAllUserRoles());
        }

        [HttpGet]
        [Route("/[controller]/GetUserRoleById/{id}")]
        [Produces("application/json")]
        public IActionResult GetUserRoleById(int id)
        {
            return Ok(userRoleService.GetUserRoleById(id));
        }

        [HttpPost]
        [Route("/[controller]/AddUserRole")]
        [Produces("application/json")]
        public IActionResult AddUserRole(UserRole userRole)
        {
            userRoleService.AddUserRole(userRole);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/UpdateUserRole")]
        [Produces("application/json")]
        public IActionResult UpdateUserRole(UserRole userRole)
        {
            userRoleService.UpdateUserRole(userRole);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/DeleteUserRole")]
        [Produces("application/json")]
        public IActionResult DeleteUserRole(int id)
        {
            userRoleService.DeleteUserRole(id);
            return Ok();
        }
    }
}
