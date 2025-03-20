C# - MONEY STREAM 🚀

A C# project following Domain-Driven Design (DDD) principles with FluentValidation for data validation.

📌 About the Project

This project is built using C# and follows Domain-Driven Design (DDD) principles to create a maintainable, scalable, and well-structured architecture. It also integrates FluentValidation, a powerful validation library, to ensure robust and clean validation logic for domain entities.

🛠️ Tech Stack</br>
	•	C# – The main programming language used for the application.</br>
	•	DDD (Domain-Driven Design) – A software design approach that structures the project around business logic.</br>
	•	FluentValidation – A NuGet package for declarative and reusable validation logic.</br>

📂 Project Structure (DDD Approach)

The project follows a layered DDD architecture, separating concerns and improving code maintainability:

```
/src  
  /Domain          # Core business logic (Entities, Value Objects, Aggregates, Domain Events)  
  /Application     # Use cases, DTOs, validation, services  
  /Infrastructure  # Database, repositories, external APIs, persistence logic  
  /Presentation    # API, Controllers, UI, CLI  
```

📝 Key Features

✅ Domain-Driven Design (DDD) – Organizes the codebase around business logic. </br>
✅ FluentValidation Integration – Provides clean, reusable, and flexible validation rules. </br>
✅ Separation of Concerns – Keeps the domain logic independent from infrastructure and UI. </br>
✅ Scalable Architecture – Easy to extend and maintain. </br>

🛠️ How FluentValidation is Used

FluentValidation is used to validate domain entities and data transfer objects (DTOs). Example:

```
public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MinimumLength(3).WithMessage("Name must be at least 3 characters long.");

        RuleFor(c => c.Email)
            .EmailAddress().WithMessage("Invalid email format.");
    }
}
```

🚀 Getting Started

📌 Prerequisites

Ensure you have the following installed:
	•	.NET SDK (version 9.0.202)
	•	Visual Studio / VS Code
	•	NuGet Package Manager

📦 Installation
	1.	Clone the repository

```
git clone https://github.com/yourusername/yourproject.git](https://github.com/Gabrielmtvp/CSHARP_MoneyStream.git
cd CSHARP_MoneyStream
```

2.	Restore dependencies

```
dotnet restore
```

3.	Run the application

```
dotnet run
```

📜 License

This project is licensed under the MIT License.
