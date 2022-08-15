using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using JiraProject.API.Helpers;
using JiraProject.API.Utilities;
using JiraProject.DAL.Context;
using JiraProject.Infrastructure.Infrastructures;
using JiraProject.Repository.GenericRepo;
using JiraProject.Repository.UnitOfWork;
using JiraProject.ServiceManager.CompanyServiceMangers;
using JiraProject.ServiceManager.MenuRoleServiceMangers;
using JiraProject.ServiceManager.MenuServiceMangers;
using JiraProject.ServiceManager.RoleServiceMangers;
using JiraProject.ServiceManager.UserRoleServiceMangers;
using JiraProject.ServiceManager.UserServiceMangers;
using JiraProject.ServiceManager.UserTokenServiceMangers;
using JiraProject.Services.CompanyServices;
using JiraProject.Services.MenuRoleServices;
using JiraProject.Services.MenuServices;
using JiraProject.Services.RoleServices;
using JiraProject.Services.UserRoleServices;
using JiraProject.Services.UserServices;
using JiraProject.Services.UserTokenServices;
using JiraProject.Services.ProjectServices;
using JiraProject.Services.ProjectUserServices;
using JiraProject.Services.ProjectIssuesServices;
using JiraProject.ServiceManager.ProjectServiceMangers;
using JiraProject.ServiceManager.ProjectUserServiceMangers;
using JiraProject.ServiceManager.StudentServiceMangers;
using JiraProject.ServiceManager.ParentServiceMangers;

namespace JiraProject.API
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

            services.AddDbContext<JiraProjectContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);

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

            services.AddHangfireServer();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IDatabaseFactory, DatabaseFactory>();
            services.AddScoped<UnitOfWork>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<UserManager>();

            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<ProjectIssuesManager>();

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

            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ProjectManager>();

            services.AddScoped<IProjectUserService, ProjectUserService>();
            services.AddScoped<ProjectUserManager>();

            services.AddScoped<IProjectIssuesService, ProjectIssuesService>();
            services.AddScoped<ProjectIssuesManager>();

            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<StudentManager>();

            services.AddScoped<IParentService, ParentService>();
            services.AddScoped<ParentManager>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

            services.AddAuthentication("Basic").AddScheme<BasicAuthenticationOptions, CustomAuthenticationHandler>("Basic", null);
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