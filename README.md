

# NeroCinemas 🎥  

NeroCinemas is a cinema management web application built using ASP.NET Core. This application facilitates managing movies, cinemas, categories, actors, and user orders efficiently while providing users with an intuitive interface to browse and purchase movie tickets.

## Table of Contents
- [Features](#features)
- [Folder Structure](#folder-structure)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Configuration](#configuration)


---

## Features

- **User Authentication**: Secure login and registration system.
- **Movie Management**: CRUD operations for movies, actors, and categories.
- **Cinema Information**: Manage cinema details and showtimes.
- **Shopping Cart**: Add, remove, and update movie tickets.
- **Order System**: Process and track customer orders.
- **MVC Architecture**: Follows Model-View-Controller pattern for scalability.

---

## Folder Structure

- **Views**: Contains Razor views for the UI of the application.
  - Subfolders: `Account`, `Actor`, `Category`, `Cinema`, `Movie`, `Order`, `ShoppingCart`, etc.
- **Models**: Contains the data models (e.g., `Actor`, `Cinema`, `Movie`, `Order`).
- **Repository**: Includes the repository pattern for managing data access (`IRepository`, `ModelsRepository`).
- **ViewModel**: View-specific models for the UI layer (e.g., `LoginVM`, `MovieVM`).
- **Controllers**: Handles user requests and communicates between the Views and Models.
  - Examples: `AccountController`, `MovieController`, `ShoppingCartController`.
- **Data**: Includes database context (`AppDbContext.cs`) and migrations.
- **CheckValidation**: Custom validation logic for the application.
- **wwwroot**: Static files for the application, such as CSS, JavaScript, and images.

---

## Technologies Used

- **ASP.NET Core MVC**: Framework for building the application.
- **Entity Framework Core**: ORM for database operations.
- **Bootstrap**: Frontend framework for responsive design.
- **SQL Server**: Relational database for data storage.

