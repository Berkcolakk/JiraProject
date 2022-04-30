using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace TestProject.API.Helpers
{
    public class AuthAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            throw new NotImplementedException();
        }
    }
}
