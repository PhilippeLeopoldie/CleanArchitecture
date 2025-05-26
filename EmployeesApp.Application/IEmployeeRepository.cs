using EmployeesApp.Domain.Models;

namespace EmployeesApp.Application;

public interface IEmployeeRepository
{
    void Add(Employee employee);
    Employee[] GetAll();
    Employee? GetById(int id);
}