
using Practice_Interface_services.Helpers.Responses;
using Practice_Interface_services.Models;

namespace Practice_Interface_services.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetAll();
        EmployeeResponse GetById(Employee[] employees, int? id);
    }
}
