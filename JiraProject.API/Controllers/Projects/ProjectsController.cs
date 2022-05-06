using JiraProject.Services.ProjectServices;
using JiraProject.Services.UserTokenServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JiraProject.API.Controllers.Projects
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : BaseController
    {
        private readonly IProjectService projectService;
        private readonly IUserTokenService userTokenService;
        public ProjectsController(IProjectService projectService, IUserTokenService userTokenService) : base(userTokenService)
        {
            this.projectService = projectService;
            this.userTokenService = userTokenService;
        }
        [HttpGet]
        [Route("/[controller]/GetAllProjects")]
        [Produces("application/json")]
        public async Task<IActionResult> GetAllProjects()
        {

            return Ok(await projectService.GetAllProjectsWithRelations(await GetUserToken()));
        }
    }
}
