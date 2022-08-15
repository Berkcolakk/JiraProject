using JiraProject.Services.CompanyServices;
using JiraProject.Services.MenuServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JiraProject.API.Controllers.Parent
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : ControllerBase
    {
        private readonly IParentService parentService;

        public ParentController(IParentService _parentService)
        {
            parentService = _parentService;
        }

        [HttpGet]
        [Route("/[controller]/GetAllParents")]
        [Produces("application/json")]
        public async Task<IActionResult> GetAllParents()
        {
            return Ok();
        }
    }
}
