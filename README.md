# Project Title
## Clean Architecture with ASP.NET

# Table of Contents
Description
Project Structure

# Description
This project demonstrates the implementation of a web application using Clean Architecture principles with ASP.NET. The solution is structured into separate projects for Domain, Application, Infrastructure, and WebApi.

# Project Structure
The project follows the Clean Architecture approach, separating concerns into distinct layers:
- Domain: Contains the core business entities, domain logic, and interfaces for external dependencies.
- Application: Implements the use cases or application-specific business rules.
- Infrastructure: Provides implementations for the external dependencies such as databases, APIs, or third-party services.
- WebApi: Exposes the web API endpoints and handles HTTP requests/responses.
