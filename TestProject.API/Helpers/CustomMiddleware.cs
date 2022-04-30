using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TestProject.Services.UserTokenServices;

namespace TestProject.API.Helpers
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public CustomMiddleware(RequestDelegate next, ILoggerFactory logFactory)
        {
            _next = next;
            _logger = logFactory.CreateLogger("CustomMiddleware");
        }

        public Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("CustomMiddleware: executing..");
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleware>();
        }
    }
}
