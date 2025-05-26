using EmployeesApp.Application;
using EmployeesApp.Infrastructure.Persistence.Repositories;
using EmployeesApp.Web.Models;



namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            //builder.Services.AddTransient<EmployeeService>();
            //builder.Services.AddSingleton<EmployeeService>();
            //builder.Services.AddSingleton<IEmployeeService, EmployeeService>();
            builder.Services.AddSingleton<IEmployeeService, OtherEmployeeService>();
            builder.Services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<MyLogServiceFilterAttribute>();
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllers();
            app.Run();
            //hej från philippe
            // hej hej från Keshti
            //David
        }
    }
}