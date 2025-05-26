using EmployeesApp.Application;
using EmployeesApp.Infrastructure.Persistence.Repositories;

namespace EmployeesApp.Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeService employeeService = new EmployeeService(new EmployeeRepository());
            var listOfEmployees = employeeService.GetAll();

            listOfEmployees
                .ToList()
                .ForEach(employee => Console.WriteLine($"Name: {employee.Name}"));
        }
    }
}
