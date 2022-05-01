using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using TestProject.API.Helpers;
using TestProject.API.Utilities;
using TestProject.DAL.Context;
using TestProject.Infrastructure.Infrastructures;
using TestProject.Repository.GenericRepo;
using TestProject.Repository.UnitOfWork;
using TestProject.ServiceManager.CompanyServiceMangers;
using TestProject.ServiceManager.MenuRoleServiceMangers;
using TestProject.ServiceManager.MenuServiceMangers;
using TestProject.ServiceManager.RoleServiceMangers;
using TestProject.ServiceManager.UserRoleServiceMangers;
using TestProject.ServiceManager.UserServiceMangers;
using TestProject.ServiceManager.UserTokenServiceMangers;
using TestProject.Services.CompanyServices;
using TestProject.Services.MenuRoleServices;
using TestProject.Services.MenuServices;
using TestProject.Services.RoleServices;
using TestProject.Services.UserRoleServices;
using TestProject.Services.UserServices;
using TestProject.Services.UserTokenServices;

namespace TestProject.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(options =>

            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
                options.JsonSerializerOptions.Converters.Add(new DateConverter());
            });

            services.AddDbContext<TestProjectContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);

            services.AddHangfire(configuration => configuration
            .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
            .UseSimpleAssemblyNameTypeSerializer()
            .UseRecommendedSerializerSettings()
            .UseSqlServerStorage(Configuration.GetConnectionString("HangfireConnection"), new SqlServerStorageOptions
            {
                CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                QueuePollInterval = TimeSpan.Zero,
                UseRecommendedIsolationLevel = true,
                DisableGlobalLocks = true
            }));

            services.AddHangfireServer();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IDatabaseFactory, DatabaseFactory>();
            services.AddScoped<UnitOfWork>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<UserManager>();

            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<RoleManager>();

            services.AddScoped<IUserRoleService, UserRoleService>();
            services.AddScoped<UserRoleManager>();

            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<CompanyManager>();

            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<MenuManager>();

            services.AddScoped<IMenuRoleService, MenuRoleService>();
            services.AddScoped<MenuRoleManager>();

            services.AddScoped<IUserTokenService, UserTokenService>();
            services.AddScoped<UserTokenManager>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder
                         .AllowAnyOrigin()
                         .AllowAnyMethod()
                         .AllowAnyHeader());

            app.UseHangfireDashboard();

            //Middleware
            app.UseMiddleware<CustomMiddleware>();

            app.UseAuthentication();

            app.UseStaticFiles();

            app.UseCookiePolicy();

            app.UseStaticHttpContext();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger");
            });
        }
    }
}