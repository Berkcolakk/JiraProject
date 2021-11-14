using Microsoft.AspNetCore.Mvc;
using TestProject.DAL.Entities;
using TestProject.Services.MenuRoleServices;

namespace TestProject.API.Controllers.Companys
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuRolesController : ControllerBase
    {
        private readonly IMenuRoleService menuRoleService;
        public MenuRolesController(IMenuRoleService _menuRoleService)
        {
            menuRoleService = _menuRoleService;
        }

        [HttpGet]
        [Route("/[controller]/GetAllMenuRoles")]
        [Produces("application/json")]
        public IActionResult GetAllMenuRoles()
        {
            return Ok(menuRoleService.GetAllMenuRoles());
        }

        [HttpGet]
        [Route("/[controller]/GetMenuRoleById/{id}")]
        [Produces("application/json")]
        public IActionResult GetMenuRoleById(int id)
        {
            return Ok(menuRoleService.GetMenuRoleById(id));
        }

        [HttpPost]
        [Route("/[controller]/AddMenuRole")]
        [Produces("application/json")]
        public IActionResult AddMenuRole(MenuRole menuRole)
        {
            menuRoleService.AddMenuRole(menuRole);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/UpdateMenuRole")]
        [Produces("application/json")]
        public IActionResult UpdateMenuRole(MenuRole menuRole)
        {
            menuRoleService.UpdateMenuRole(menuRole);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/DeleteMenuRole")]
        [Produces("application/json")]
        public IActionResult DeleteMenuRole(int id)
        {
            menuRoleService.DeleteMenuRole(id);
            return Ok();
        }
    }
}
