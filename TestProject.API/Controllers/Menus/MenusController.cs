using Microsoft.AspNetCore.Mvc;
using TestProject.DAL.Entities;
using TestProject.Services.MenuServices;

namespace TestProject.API.Controllers.Companys
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService menuService;
        public MenuController(IMenuService _menuService)
        {
            menuService = _menuService;
        }

        [HttpGet]
        [Route("/[controller]/GetAllMenus")]
        [Produces("application/json")]
        public IActionResult GetAllMenus()
        {
            return Ok(menuService.GetAllMenus());
        }

        [HttpGet]
        [Route("/[controller]/GetMenuById/{id}")]
        [Produces("application/json")]
        public IActionResult GetMenuById(int id)
        {
            return Ok(menuService.GetMenuById(id));
        }

        [HttpPost]
        [Route("/[controller]/AddMenu")]
        [Produces("application/json")]
        public IActionResult AddMenu(Menu menu)
        {
            menuService.AddMenu(menu);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/UpdateMenu")]
        [Produces("application/json")]
        public IActionResult UpdateMenu(Menu menu)
        {
            menuService.UpdateMenu(menu);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/DeleteMenu")]
        [Produces("application/json")]
        public IActionResult DeleteMenu(int id)
        {
            menuService.DeleteMenu(id);
            return Ok();
        }
    }
}
