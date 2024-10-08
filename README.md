# Employment Verification System

## Overview
The Employment Verification System consists of two projects:
1. **EmploymentVerificationAPI**: An ASP.NET Core Web API that handles employment verification requests.
2. **EmploymentVerificationWeb**: An ASP.NET Core MVC application that serves as the frontend, allowing users to input employee information for verification.

## Approach
- **Backend (EmploymentVerificationAPI)**: 
  - Implemented as a RESTful API that exposes a single endpoint `/api/verify-employment` to verify employee information based on a provided employee ID, company name, and verification code.
  - An in-memory list of employee records is used for demonstration purposes.

- **Frontend (EmploymentVerificationWeb)**: 
  - Developed using ASP.NET Core MVC, allowing users to input employee details via a form.
  - Upon form submission, it sends a POST request to the backend API and displays the verification result.

## Assumptions
- The API uses an in-memory data structure to store employee information, which means data will not persist after the application is stopped.
- Basic input validation is performed; however, more comprehensive validation can be added as needed.
- The applications are set up to run locally on the default ports. Ensure no other services are using these ports.

## Prerequisites
- [.NET SDK 8.0 or later](https://dotnet.microsoft.com/download)
- An IDE or text editor (e.g., Visual Studio, Visual Studio Code)

## Compiling and Running the Program

### Notes

- **Running Both Projects Simultaneously**: Ensure that both the API and the Web projects are running at the same time. If necessary, open two instances of Visual Studio for each project.
- **CORS Configuration**: If you encounter cross-origin request (CORS) issues, ensure that the API has proper CORS policy configuration, allowing the frontend to make requests.
- **Ports**: Make sure the ports used by both projects are different and not conflicting with other running services on your machine.
