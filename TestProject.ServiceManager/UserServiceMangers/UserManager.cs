using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TestProject.DAL.Context;
using TestProject.DAL.Entities;
using TestProject.Dto.User.Auth;

namespace TestProject.ServiceManager.UserServiceMangers
{
    public class UserManager
    {
        private readonly TestProjectContext context;
        public UserManager(TestProjectContext context)
        {
            this.context = context;
        }
    }
}
