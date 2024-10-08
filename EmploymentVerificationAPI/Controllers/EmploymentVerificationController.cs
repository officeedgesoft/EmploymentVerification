using EmploymentVerificationAPI.Models;
using EmploymentVerificationAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentVerificationAPI.Controllers
{
    [Route("api/verify-employment")]
    [ApiController]
    public class EmploymentVerificationController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmploymentVerificationController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public IActionResult VerifyEmployment([FromBody] EmployeeVerificationRequest request)
        {
            // Check if the request is null
            if (request == null)
            {
                return BadRequest("Request body cannot be null.");
            }

            // Validate and verify employee
            bool isVerified = _employeeService.VerifyEmployee(request, out string errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                return BadRequest(errorMessage);
            }

            return Ok(new { verified = isVerified });
        }
    }
}
