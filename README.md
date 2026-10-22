# 🚀 Clean Best Code Practices (C# Console)

This project demonstrates **best coding practices in C#** with simple, self-contained console examples.
The goal is to write **clean, readable, maintainable, and professional code**.

Each topic lives in its own console project so you can read, run, and experiment with one practice at a time.

---

## 📌 All Demo Projects

| # | Project | What It Demonstrates |
|---|---------|----------------------|
| 1 | `AbstractClassDemo.Console` | Abstract classes with abstract + concrete methods |
| 2 | `AbstractClassDesignDemo.Console` | Designing abstract classes (constructors, fields, properties, events) |
| 3 | `AsyncNamingDemo.Console` | Use the `Async` suffix for async methods |
| 4 | `AutoPropertyDemo.Console` | Use auto-implemented properties |
| 5 | `CleanCodeDemo.Console` | Avoid commented-out code — use source control instead |
| 6 | `CleanInitializationDemo.Console` | Remove member initialization when values are set before use |
| 7 | `CurlyBracesDemo.Console` | Always use curly braces to define scope, even for one-liners |
| 8 | `DefaultValuesDemo.Console` | Assign default values properly |
| 9 | `DependencyInjectionDemo.Console` | Dependency injection for loose coupling and testability |
| 10 | `EnumDemo.Console` | Use enums properly with explicit integer values |
| 11 | `ExceptionHandlingDemo.Console` | Never leave empty catch blocks; proper exception handling |
| 12 | `FieldVsPropertyDemo.Console` | Encapsulation — never use public fields, use properties |
| 13 | `GuidBestPractices.Console` | Avoid `new Guid()` → use `Guid.NewGuid()` |
| 14 | `IfStatementOptimizationDemo.Console` | Merge nested `if` statements to improve readability |
| 15 | `IfVsSwitchDemo.Console` | Use `if-else` vs `switch` appropriately |
| 16 | `LooseCouplingDemo.Console` | Avoid tight coupling between classes |
| 17 | `MethodParameterDemo.Console` | Avoid too many method parameters |
| 18 | `MethodRefactoringDemo.Console` | Avoid long methods — refactor into smaller ones |
| 19 | `NameofDemo.Console` | Use `nameof()` instead of hardcoded strings |
| 20 | `NamingConventionDemo.Console` | PascalCase for types/members; meaningful variable names |
| 21 | `ParentChildDemo.Console` | Parent-Child inheritance |
| 22 | `PropertiesConstructorDemo.Console` | Properties and constructor initialization; getter-only properties |
| 23 | `PropertyVsMethodDemo.Console` | Avoid write-only properties — use a method instead |
| 24 | `ReadableCodeDemo.Console` | Simplify complex expressions for readability |
| 25 | `RegionDemo.Console` | Use `#region` to organize large code sections |
| 26 | `SealedClassDemo.Console` | Sealed classes; don't add `protected` members in a sealed class |
| 27 | `SwitchRefactoringDemo.Console` | Use methods inside `switch` instead of long inline logic |
| 28 | `SwitchVsDictionaryDemo.Console` | Use `Dictionary` instead of large `switch` statements |
| 29 | `TernaryVsIfElseDemo.Console` | Avoid nested ternary operators |
| 30 | `TodoFixmeDemo.Console` | Track `TODO` and `FIXME` properly |
| 31 | `VariableDeclarationDemo.Console` | Avoid multiple variable declarations on one line |

---

## 📂 Topics by Category

### 🧱 OOP & Design Principles

* Parent-Child (Inheritance)
* Encapsulation (Properties vs Fields)
* Abstract Class (Abstract + Concrete methods)
* Abstract Class Design (constructors, fields, properties, events)
* Sealed Class (no protected members)
* Dependency Injection (loose coupling, testability)
* Loose Coupling between classes

---

### 🧹 Clean Code Practices

* Avoid long methods (Method Refactoring)
* Avoid too many method parameters
* Avoid nested ternary operators
* Avoid large switch statements
* Use Dictionary instead of large switch
* Use methods inside switch instead of long logic
* Avoid commented-out code — use source control
* Remove unnecessary member initialization
* Simplify complex expressions for readability
* Use `#region` to organize large code sections

---

### 🏷️ Naming Conventions

* Use PascalCase for Classes, Methods, Properties
* Use meaningful variable names
* Use `nameof()` instead of hardcoded strings
* Use the `Async` suffix for async methods

---

### ⚙️ Properties & Fields

* Never use public fields
* Use auto-implemented properties
* Avoid write-only properties — use a method instead
* Use getter-only properties where applicable
* Initialize properties via constructors
* Use `readonly` where applicable

---

### 🧠 Control Flow Best Practices

* Use if-else vs switch appropriately
* Merge nested if statements for readability
* Maintain consistency in curly braces
* Avoid nested conditions

---

### ⚠️ Error Handling

* Never leave empty catch blocks
* Proper exception handling and logging

---

### 🛠️ Code Quality Rules

* Avoid commented-out code
* Track TODO and FIXME properly
* Avoid multiple variable declarations in one line
* Assign default values properly
* Keep lines short and readable

---

### 🔑 Miscellaneous

* Avoid using `new Guid()` → use `Guid.NewGuid()`
* Use enum properly with integer values
* Avoid tight coupling between classes

---

## 🎯 Purpose of this Project

* Improve coding standards
* Write professional-level code
* Prepare for interviews
* Build real-world coding habits

---

## 🧠 Key Learning

> "Clean code is not about writing less code, it's about writing **better code**."

---

## ⭐ How to Run

### Prerequisites

* [.NET 10.0 SDK](https://dotnet.microsoft.com/download)
* Visual Studio 2022+ or VS Code

### Option 1 — Visual Studio

1. Clone the repository
2. Open `Best-Coding-Practice.slnx`
3. Set any console project as the startup project
4. Press `F5` to run

### Option 2 — .NET CLI

```bash
# Clone the repository
git clone <repo-url>
cd Best-Coding-Practice-CSharp

# Run a specific demo
dotnet run --project AbstractClassDemo.Console

# Or build the entire solution
dotnet build Best-Coding-Practice.slnx
```

---

## 💡 Future Improvements

* Add SOLID principles examples
* Add real-world project structure
* Add unit testing
* Add more design pattern demos
