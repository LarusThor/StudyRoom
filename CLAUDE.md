# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

StudyRoom is a multi-service .NET 10 application with three services:

- **StudyRoom.Api** – ASP.NET Core MVC app (not REST API despite the name). Handles user auth, views, and primary business logic.
- **StudyRoom.Gateway** – Planned WebSocket realtime gateway (currently scaffold only).
- **StudyRoom.Worker** – .NET background service (currently scaffold only).

Planned data layer: **PostgreSQL** and **RabbitMQ** (not yet integrated; Api currently uses SQL Server via Docker).

## Commands

Run from within each project directory (`src/StudyRoom.Api`, etc.):

```bash
# Build
dotnet build

# Run the API (default port: https://localhost:7091)
dotnet run --project src/StudyRoom.Api/StudyRoom.Api.csproj

# EF Core migrations (run from src/StudyRoom.Api/)
dotnet ef migrations add <MigrationName>
dotnet ef database update
```

There are no tests yet.

## Architecture

### StudyRoom.Api

MVC app with ASP.NET Core Identity using **SQL Server** (Docker on port 1433). The connection string is in `appsettings.json`.

**Layer structure:**
- `Models/` – `ApplicationUser` (extends `IdentityUser<Guid>`), `ApplicationRole` (extends `IdentityRole<Guid>`), `Address`
- `Data/ApplicationDbContext.cs` – EF Core context extending `IdentityDbContext<ApplicationUser, ApplicationRole, Guid>`. Seeds four roles (admin, User, Manager, Guest) with fixed GUIDs.
- `Services/Interfaces/` – `IAccountService`, `IEmailService`
- `Services/Implementations/` – `AccountService` (registration, email confirmation, login/logout, profile), `EmailService` (SMTP via Gmail)
- `Controllers/` – `AccountController` delegates all logic to `IAccountService`
- `ViewModels/` – DTOs for Register, Login, Profile, ResendConfirmationEmail

**Email flow:** On registration, a Base64Url-encoded confirmation token is sent via SMTP. Token lifespan is 30 minutes. `AppSettings:BaseUrl` in `appsettings.json` must be set for confirmation links to work.

**Configuration required in `appsettings.json`:**
- `ConnectionStrings:SQLServerIdentityConnection` – SQL Server connection
- `EmailSettings` – SmtpServer, SmtpPort, SenderName, SenderEmail, Password (Gmail App Password)
- `AppSettings:BaseUrl` – base URL for email confirmation links (default: `https://localhost:7091`)

### Namespaces

The codebase uses mixed namespaces: `StudyRoom.*` for services/models/data, but `ASPNETCoreIdentityDemo` for the `Program` class in the API. This is an inconsistency to be aware of.
