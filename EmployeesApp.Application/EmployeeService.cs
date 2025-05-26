using EmployeesApp.Domain.Models;

namespace EmployeesApp.Application;

public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
{
    public void Add(Employee employee)
    {
        employeeRepository.Add(employee);
    }



    public Employee[] GetAll()
    {
        return employeeRepository.GetAll();
    }



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