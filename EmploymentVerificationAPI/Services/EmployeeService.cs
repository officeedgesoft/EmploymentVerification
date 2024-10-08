using EmploymentVerificationAPI.Models;

namespace EmploymentVerificationAPI.Services
{
    public partial class EmployeeService : IEmployeeService
    {
        private static readonly List<Employee> Employees = new()
        {
            new Employee { EmployeeId = 1, CompanyName = "Tech Corp", VerificationCode = "ABC123" },
            new Employee { EmployeeId = 2, CompanyName = "Business Inc", VerificationCode = "XYZ789" },
            new Employee { EmployeeId = 3, CompanyName = "Retail Co", VerificationCode = "LMN456" },
            new Employee { EmployeeId = 4, CompanyName = "Finance Solutions", VerificationCode = "FIN2023" },
            new Employee { EmployeeId = 5, CompanyName = "Health Corp", VerificationCode = "HEALTH20" },
            new Employee { EmployeeId = 6, CompanyName = "Travel Agency", VerificationCode = "TRAVEL99" },
            new Employee { EmployeeId = 7, CompanyName = "Construction Ltd", VerificationCode = "BUILD2024" },
            new Employee { EmployeeId = 8, CompanyName = "Hospitality Group", VerificationCode = "HOSP1234" },
            new Employee { EmployeeId = 9, CompanyName = "Media Co", VerificationCode = "MEDIA2024" },
            new Employee { EmployeeId = 10, CompanyName = "Education Hub", VerificationCode = "EDU5678" }
        };

        public bool VerifyEmployee(EmployeeVerificationRequest request, out string errorMessage)
        {
            errorMessage = string.Empty;

            // Validate input fields
            if (request.EmployeeId <= 0)
            {
                errorMessage = "Employee ID must be a positive number.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(request.CompanyName))
            {
                errorMessage = "Company Name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(request.VerificationCode))
            {
                errorMessage = "Verification Code is required.";
                return false;
            }

            // Check if the employee exists
            var employee = Employees.FirstOrDefault(e =>
                e.EmployeeId == request.EmployeeId &&
                e.CompanyName.Equals(request.CompanyName, StringComparison.OrdinalIgnoreCase));

            // If employee is found, verify the verification code
            if (employee == null)
            {
                errorMessage = "Employee not found.";
                return false;
            }

            return employee.VerificationCode.Equals(request.VerificationCode, StringComparison.OrdinalIgnoreCase);
        }

        public List<Employee> GetEmployees() {
            return Employees;
        }
    }
}
