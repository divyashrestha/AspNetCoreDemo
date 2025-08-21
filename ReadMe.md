# AspNetCoreDemo 🎯

A lightweight ASP.NET Core MVC web application using SQLite as the backend database. Built for rapid prototyping and educational purposes, this demo showcases how to scaffold models, configure EF Core, and build CRUD interfaces using Razor views.

---

## 🚀 Features

- ASP.NET Core MVC architecture
- SQLite database integration via Entity Framework Core
- Razor Pages for CRUD operations
- EF Core migrations and schema management
- Modular folder structure for scalability

---

## 🧰 Tech Stack

- **Framework**: ASP.NET Core 8.0
- **Database**: SQLite (`app.db`)
- **ORM**: Entity Framework Core
- **IDE**: Visual Studio Code
- **Language**: C#
- **Frontend**: Razor Views, HTML/CSS

---

## 🛠️ Getting Started

### Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio Code](https://code.visualstudio.com/)
- C# and EF Core extensions for VS Code

### Installation

```bash
# Clone the repository
git clone https://github.com/divyashrestha/AspNetCoreDemo.git
cd AspNetCoreDemo

# Restore dependencies
dotnet restore

# Apply migrations and create database
dotnet ef database update

# Run the app
dotnet run

# Project Structure
AspNetCoreDemo/
├── Controllers/         # MVC controllers
├── Models/              # Entity models
├── Data/                # DbContext and EF Core setup
├── Views/               # Razor views
├── Migrations/          # EF Core migration files
├── wwwroot/             # Static assets
├── app.db               # SQLite database file
├── Program.cs           # App entry point
├── appsettings.json     # Configuration

