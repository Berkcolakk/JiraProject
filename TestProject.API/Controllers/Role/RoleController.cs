using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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
        public async Task<IActionResult> GetAllRoles()
        {
            return Ok(await roleService.GetAllRoles());
        }

        [HttpGet]
        [Route("/[controller]/GetRolesById/{id}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetRolesById(int id)
        {
            return Ok(await roleService.GetRolesById(id));
        }

        [HttpPost]
        [Route("/[controller]/AddRoles")]
        [Produces("application/json")]
        public async Task<IActionResult> AddRoles(Roles roles)
        {
            await roleService.AddRoles(roles);
            return Ok();
        }

        [HttpPut]
        [Route("/[controller]/UpdateRoles")]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateRoles(Roles roles)
        {
            await roleService.UpdateRoles(roles);
            return Ok();
        }

        [HttpDelete]
        [Route("/[controller]/DeleteRoles")]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteRoles(int id)
        {
            await roleService.DeleteRoles(id);
            return Ok();
        }
    }
}