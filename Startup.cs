using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyProject.BLL.IServices;
using MyProject.BLL.Services;
using MyProject.Core.Validations;
using MyProject.DAL.DataContext;
using MyProject.DAL.IRepositories;
using MyProject.DAL.Repositories;
using MyProject.DTOs.UserDTOs;
using MyProject.Utility;

namespace MyProject
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
            services.AddAutoMapper(typeof(Automapper));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IFromCityRepository, FromCityRepository>();
            services.AddScoped<IFromCityService, FromCityService>();

            services.AddScoped<IToCityRepository, ToCityRepository>();
            services.AddScoped<IToCityService, ToCityService>();

            services.AddScoped<IFlightRepository, FlightRepository>();
            services.AddScoped<IFlightService, FlightService>();

            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<ITicketService, TicketService>();

            services.AddControllersWithViews();
            services.AddDbContext<TestDbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("AppDb"));
            });
            services.AddSingleton<IValidator<UserToAddDTO>, UserValidator>();
            services.AddControllers().SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddFluentValidation();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=User}/{action=Index}/{id?}");
        //pattern: "{controller=Flight}/{action=SaleTicket}/{id?}");
            });
        }
    }
}
