using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using JiraProject.API.Utilities;
using JiraProject.DAL.Entities;
using JiraProject.Services.UserTokenServices;

namespace JiraProject.API.Helpers
{
    public class BasicAuthenticationOptions : AuthenticationSchemeOptions { }
    public class CustomAuthenticationHandler : AuthenticationHandler<BasicAuthenticationOptions>
    {
        private readonly IUserTokenService userTokenService;
        public CustomAuthenticationHandler(IOptionsMonitor<BasicAuthenticationOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, IUserTokenService userTokenService) : base(options, logger, encoder, clock)
        {
            this.userTokenService = userTokenService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Unauthorized");
            string authorizationKey = Request.Headers["Authorization"];
            if (string.IsNullOrEmpty(authorizationKey))
                return AuthenticateResult.Fail("Unauthorized");

            try
            {
                return await ValidateToken(Request.Headers["Authorization"]);
            }
            catch (Exception)
            {
                return AuthenticateResult.Fail("Unauthorized");
            }
        }

        public async Task<AuthenticateResult> ValidateToken(string token)
        {
            UserToken userToken = await userTokenService.CheckTokenByUserToken(token);
            if (userToken != null)
            {
                return AuthenticateResult.Success(
  new AuthenticationTicket(
      new ClaimsPrincipal(
          new ClaimsIdentity(
              new List<Claim>() { new Claim(ClaimTypes.Sid, token) }, Scheme.Name)),
      Scheme.Name));
            }
            else
            {
                return AuthenticateResult.Fail("Unauthorized");
            }
        }
    }
}