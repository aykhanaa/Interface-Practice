
using Practice_Interface_services.Models;
using Practice_Interface_services.Services.Interfaces;
using Practice_Interface_Services.Services;
using System.Threading.Tasks;

namespace Practice_Interface_services.Controlles
{
    public class EmployeeController
    {private readonly IEmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }
        public void GetAll()
        {
            var employess = _employeeService.GetAll();

            foreach (var employee in employess)
            {
                string result = $"{employee.Name} {employee.Surname} {employee.Address} " +
                    $"{employee.Email} {employee.Age} {employee.Birthday.ToString("MM-dd-yyyy")}";
                Console.WriteLine(result);
            }
        }
        public void GetById()
        {
            int? id = null;
            var response = _employeeService.GetById(_employeeService.GetAll(), id);
            if (response.ErrorMessage is null)
            {
                string result = $"{response.Employee.Name} {response.Employee.Surname} {response.Employee.Address} " +
                    $"{response.Employee.Email} {response.Employee.Age} {response.Employee.Birthday.ToString("MM-dd-yyyy")}";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }
    }
}
