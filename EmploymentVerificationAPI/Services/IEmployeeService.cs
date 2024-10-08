using EmploymentVerificationAPI.Models;

namespace EmploymentVerificationAPI.Services
{
    public interface IEmployeeService
    {
        bool VerifyEmployee(EmployeeVerificationRequest request, out string errorMessage);

        List<Employee> GetEmployees();
    }
}
