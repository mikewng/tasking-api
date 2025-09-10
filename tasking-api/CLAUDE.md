# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview
This is a .NET 8 Web API project for a task management system. The application provides REST endpoints for managing boards and tasks, following a clean architecture pattern with separation of concerns.

## Development Commands

### Build and Run
- `dotnet build` - Build the project
- `dotnet run` - Run the application (launches on https://localhost:7023 and http://localhost:5127)
- `dotnet run --launch-profile http` - Run with HTTP profile only
- `dotnet run --launch-profile https` - Run with HTTPS profile (default)

### Testing
- `dotnet test` - Run all tests (currently minimal test structure in place)

### Package Management
- `dotnet restore` - Restore NuGet packages
- `dotnet add package [PackageName]` - Add NuGet packages

## Architecture Overview

### Project Structure
The codebase follows a layered architecture:

- **Controllers/** - Web API controllers handling HTTP requests
- **Main/** - Core business logic and infrastructure
  - **Models/** - Domain entities (Board, BoardTask, User, Result pattern)
  - **Models/DTO/** - Data Transfer Objects for API communication
  - **Service/Contracts/** - Service interfaces defining business operations
  - **Data/** - Repository pattern interfaces
  - **Secure/** - Security-related interfaces
  - **Extensions/** - Extension methods (currently empty but intended for configuration)

### Key Patterns

#### Result Pattern
The application uses a custom Result<T> pattern for operation outcomes:
- `Result<T>.Ok(value)` - Success with value
- `Result<T>.Fail(error)` - Failure with error message
- `Result.Ok()` - Success without value
- `Result.Fail(error)` - Failure without value

#### Dependency Injection
Services are registered in Program.cs and injected into controllers:
- IBoardService - Board management operations
- ITaskService - Task management operations
- IUserService - User management operations
- ICalendarService - Calendar integration

### Domain Model
- **Board**: Contains tasks, has owner, name, and description
- **BoardTask**: Individual task items with deadlines
- **User**: User entity for authentication/authorization
- **BoardRequest**: DTO for board creation requests

## Development Notes

### API Documentation
- Swagger UI available at `/swagger` when running in Development mode
- API endpoints follow RESTful conventions
- Route pattern: `[controller]` maps to controller name

### Current Implementation Status
- Basic CRUD operations for boards implemented in TaskingController
- Service contracts defined but implementations not yet created
- Authentication system structure in place but not implemented
- Test framework present but tests not implemented

### Configuration
- Development and Production appsettings configured
- HTTPS redirection enabled
- Swagger enabled for Development environment
- Anonymous authentication currently enabled