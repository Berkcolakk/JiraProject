﻿using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace TestProject.API.Helpers
{
    public class AuthAttribute : Attribute, IAuthorizationFilter
    {
        //private readonly IUserTokenService userTokenService;
        //public AuthAttribute(IUserTokenService userTokenService)
        //{
        //    this.userTokenService = userTokenService;
        //}
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //string authKey = context.HttpContext.Request.Headers["Authorization"];
            //if (!String.IsNullOrEmpty(authKey))
            //{
            //    bool isLogin = await userTokenService.CheckTokenByUserToken(authKey);
            //}
            //else
            //{
            //    throw new NotImplementedException();
            //}
        }
    }
}