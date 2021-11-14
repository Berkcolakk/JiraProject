using Microsoft.AspNetCore.Mvc;
using TestProject.DAL.Entities;
using TestProject.Services.CompanyServices;

namespace TestProject.API.Controllers.Companys
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService companyService;
        public CompanyController(ICompanyService _companyService)
        {
            companyService = _companyService;
        }

        [HttpGet]
        [Route("/[controller]/GetAllCompanys")]
        [Produces("application/json")]
        public IActionResult GetAllCompanys()
        {
            return Ok(companyService.GetAllCompanys());
        }

        [HttpGet]
        [Route("/[controller]/GetCompanyById/{id}")]
        [Produces("application/json")]
        public IActionResult GetCompanyById(int id)
        {
            return Ok(companyService.GetCompanyById(id));
        }

        [HttpPost]
        [Route("/[controller]/AddCompany")]
        [Produces("application/json")]
        public IActionResult AddCompany(Company company)
        {
            companyService.AddCompany(company);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/UpdateCompany")]
        [Produces("application/json")]
        public IActionResult UpdateCompany(Company company)
        {
            companyService.UpdateCompany(company);
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/DeleteCompany")]
        [Produces("application/json")]
        public IActionResult DeleteCompany(int id)
        {
            companyService.DeleteCompany(id);
            return Ok();
        }
    }
}
