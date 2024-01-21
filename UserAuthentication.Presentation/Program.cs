using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserAthentication.Domain.IRepositories;
using UserAuthentication.Application.Commands;
using UserAuthentication.Application.Commands.Handlers;
using UserAuthentication.Application.Common;
using UserAuthentication.Infrastructure.Common;
using UserAuthentication.Infrastructure.Repositories;

namespace UserAuthentication.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //DataBase
            builder.Services.AddDbContext<ApplicationDbContext>(
                x => x.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefualtConnection")));



            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));

            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IUnitOfWork ,UnitOfWork>();
            builder.Services.AddScoped<IRequestHandler<CreateUserCommand, bool>, CreateUserCommandHandler>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}