using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Threading.Tasks;

namespace JiraProject.API.Controllers.ImageProccessor
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageProcessor : ControllerBase
    {
        const int size = 150;
        const int quality = 75;
        public async Task<IActionResult> LoginWithCamera()
        {
            return Ok();
        }
        public async Task<IActionResult> SetMyProfile()
        {
            return Ok();
        }
    }
}
