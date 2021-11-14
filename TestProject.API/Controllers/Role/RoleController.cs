using Microsoft.AspNetCore.Mvc;
using TestProject.DAL.Entities;
using TestProject.Services.RoleServices;

namespace TestProject.API.Controllers.Role
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService roleService;
        public RoleController(IRoleService _roleService)
        {
            roleService = _roleService;
        }

        [HttpGet]
        [Route("/[controller]/GetAllRoles")]
        [Produces("application/json")]
        public IActionResult GetAllRoles()
        {
            return Ok(roleService.GetAllRoles());
        }

        [HttpGet]
        [Route("/[controller]/GetRolesById/{id}")]
        [Produces("application/json")]
        public IActionResult GetRolesById(int id)
        {
            return Ok(roleService.GetRolesById(id));
        }

        [HttpPost]
        [Route("/[controller]/AddRoles")]
        [Produces("application/json")]
        public IActionResult AddRoles(Roles roles)
        {
            roleService.AddRoles(roles);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/UpdateRoles")]
        [Produces("application/json")]
        public IActionResult UpdateRoles(Roles roles)
        {
            roleService.UpdateRoles(roles);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/DeleteRoles")]
        [Produces("application/json")]
        public IActionResult DeleteRoles(int id)
        {
            roleService.DeleteRoles(id);
            return Ok();
        }
    }
}
