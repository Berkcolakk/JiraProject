using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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
        public async Task<IActionResult> GetAllMenus()
        {
            return Ok(await menuService.GetAllMenus());
        }

        [HttpGet]
        [Route("/[controller]/GetMenuById/{id}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetMenuById(int id)
        {
            return Ok(await menuService.GetMenuById(id));
        }

        [HttpPost]
        [Route("/[controller]/AddMenu")]
        [Produces("application/json")]
        public async Task<IActionResult> AddMenu(Menu menu)
        {
            await menuService.AddMenu(menu);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/UpdateMenu")]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateMenu(Menu menu)
        {
            await menuService.UpdateMenu(menu);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/DeleteMenu")]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            await menuService.DeleteMenu(id);
            return Ok();
        }
    }
}
