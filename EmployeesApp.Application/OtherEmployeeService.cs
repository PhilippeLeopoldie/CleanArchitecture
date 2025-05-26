using EmployeesApp.Domain.Models;

namespace EmployeesApp.Application;

public class OtherEmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
{
    public void Add(Employee employee)
    {
        employeeRepository.Add(employee);
    }


    // Collection expression syntax, introduced in C# 12.
    public Employee[] GetAll() => employeeRepository.GetAll();

    ////Classic C# syntax for GetAll()
    //public Employee[] GetAll()
    //{
    //    return employees
    //        .OrderBy(e => e.Name)
    //        .ToArray();
    //}

    public Employee GetById(int id)
    {
        var employee = employeeRepository.GetById(id);
        if (employee == null)
        {
            throw new ArgumentException($"No employee found with ID {id}");
        }

        return employee;
    }

    public bool CheckIsVIP(Employee employee) =>
        employee.Email.StartsWith("ADMIN", StringComparison.CurrentCultureIgnoreCase);
}