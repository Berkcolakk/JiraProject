﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using JiraProject.DAL.Entities;
using JiraProject.Services.CompanyServices;

namespace JiraProject.API.Controllers.Companys
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
        public async Task<IActionResult> GetAllCompanys()
        {
            return Ok(await companyService.GetAllCompanys());
        }

        [HttpGet]
        [Route("/[controller]/GetCompanyById/{id}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetCompanyById(int id)
        {
            return Ok(await companyService.GetCompanyById(id));
        }

        [HttpPost]
        [Route("/[controller]/AddCompany")]
        [Produces("application/json")]
        public async Task<IActionResult> AddCompany(Company company)
        {
            await companyService.AddCompany(company);
            return Ok();
        }

        [HttpPut]
        [Route("/[controller]/UpdateCompany")]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateCompany(Company company)
        {
            await companyService.UpdateCompany(company);
            return Ok();
        }

        [HttpDelete]
        [Route("/[controller]/DeleteCompany")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            await companyService.DeleteCompany(id);
            return Ok();
        }
    }
}