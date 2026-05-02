<div align="center">

# 🏗️ Learning Layered Architecture in .NET

![.NET](https://img.shields.io/badge/.NET-6%2B-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![Status](https://img.shields.io/badge/Status-In%20Progress-yellow?style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-blue?style=for-the-badge)

> A hands-on study repository to understand and practice **Layered (N-Tier) Architecture** with **C# and .NET**, focusing on separation of concerns, clean code organization, and real-world project structure.

</div>

---

## 📖 About This Project

This repository documents my learning journey through **Layered Architecture** — one of the most widely used architectural patterns in enterprise .NET applications. Each folder and commit represents a step forward in understanding how to properly separate responsibilities across layers, making codebases easier to maintain, test, and scale.

---

## 🧱 Architecture Overview

```
┌──────────────────────────────────────┐
│         Presentation Layer           │  ← API Controllers / Endpoints
├──────────────────────────────────────┤
│          Application Layer           │  ← Services / Use Cases / DTOs
├──────────────────────────────────────┤
│           Domain Layer               │  ← Entities / Interfaces / Business Rules
├──────────────────────────────────────┤
│        Infrastructure Layer          │  ← Database / Repositories / External Services
└──────────────────────────────────────┘
```

| Layer | Responsibility | Key Components |
|-------|---------------|----------------|
| **Presentation** | Receives HTTP requests and returns responses | Controllers, Middlewares |
| **Application** | Orchestrates business logic flow | Services, DTOs, Mappers |
| **Domain** | Core business rules, independent of frameworks | Entities, Interfaces, Enums |
| **Infrastructure** | Data persistence and external integrations | DbContext, Repositories, Migrations |

---

## 📁 Project Structure

```
learning_layered/
│
├── src/
│   ├── Presentation/          # API layer (Controllers, Minimal APIs)
│   ├── Application/           # Services, DTOs, Interfaces
│   ├── Domain/                # Entities, Business Rules, Abstractions
│   └── Infrastructure/        # EF Core, Repositories, DB Config
│
├── tests/                     # Unit & Integration tests
│
└── README.md
```

---

## 🚀 Technologies & Tools

- **[.NET 6+](https://dotnet.microsoft.com/)** — Framework
- **[ASP.NET Core](https://docs.microsoft.com/aspnet/core)** — Web API
- **[Entity Framework Core](https://docs.microsoft.com/ef/core)** — ORM / Data Access
- **[Swagger / Swashbuckle](https://swagger.io/)** — API Documentation
- **[xUnit](https://xunit.net/)** — Unit Testing

---

## 🎯 Learning Goals

- [x] Understand the purpose of each layer and its boundaries
- [x] Create domain entities with encapsulated business logic
- [ ] Implement the Repository Pattern in the Infrastructure layer
- [ ] Use Dependency Injection to decouple layers
- [ ] Map domain objects to DTOs in the Application layer
- [ ] Write unit tests for the Application layer

---

## ▶️ Getting Started

### Prerequisites

- [.NET 6+ SDK](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/)

### Running Locally

```bash
# Clone the repository
git clone https://github.com/martoxm/learning_layered.git

# Navigate to the project folder
cd learning_layered

# Restore dependencies
dotnet restore

# Run the application
dotnet run --project src/Presentation
```

---

## 📚 Study References

- [Microsoft — App Architecture Guide](https://docs.microsoft.com/dotnet/architecture/)
- [Clean Architecture — Robert C. Martin](https://www.amazon.com/Clean-Architecture-Craftsmans-Software-Structure/dp/0134494164)
- [Rocketseat](https://www.rocketseat.com.br/) — .NET Formation

---

## 👨‍💻 Author

<div align="center">

**Gabriel Martorelli**
Junior Developer | C# & .NET Enthusiast

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/gabrielmartorelli)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/martoxm)

*"Every expert was once a beginner."*

</div>

---

<div align="center">
⭐ If this repo helped you in any way, consider leaving a star!
</div>
