﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using JiraProject.DAL.Entities;
using JiraProject.Services.MenuRoleServices;

namespace JiraProject.API.Controllers.Companys
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
        public async Task<IActionResult> GetAllMenuRoles()
        {
            return Ok(await menuRoleService.GetAllMenuRoles());
        }

        [HttpGet]
        [Route("/[controller]/GetMenuRoleById/{id}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetMenuRoleById(int id)
        {
            return Ok(await menuRoleService.GetMenuRoleById(id));
        }

        [HttpPost]
        [Route("/[controller]/AddMenuRole")]
        [Produces("application/json")]
        public async Task<IActionResult> AddMenuRole(MenuRole menuRole)
        {
            await menuRoleService.AddMenuRole(menuRole);
            return Ok();
        }

        [HttpPut]
        [Route("/[controller]/UpdateMenuRole")]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateMenuRole(MenuRole menuRole)
        {
            await menuRoleService.UpdateMenuRole(menuRole);
            return Ok();
        }

        [HttpDelete]
        [Route("/[controller]/DeleteMenuRole")]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteMenuRole(int id)
        {
            await menuRoleService.DeleteMenuRole(id);
            return Ok();
        }
    }
}