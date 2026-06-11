# Cars with SQL Database
![image alt](https://github.com/howard618/CarswithSQLDatabase/blob/631cd24cc54b608f9748b5f636d834f1245987c0/carmanagement.jpg)
## Overview

Cars with SQL Database is a C# WPF desktop application that demonstrates full CRUD (Create, Read, Update, Delete) functionality using Entity Framework Core and SQL Server.

The application allows users to manage a collection of vehicles by storing and retrieving data from a SQL Server database. Users can add, update, delete, and view car records through a graphical user interface built with Windows Presentation Foundation (WPF).

This project was developed to gain hands-on experience with:

* Entity Framework Core
* SQL Server
* Code-First Database Design
* WPF Desktop Development
* CRUD Operations
* Data Binding
* Object Relational Mapping (ORM)

---

## Technologies Used

* C#
* .NET
* WPF (Windows Presentation Foundation)
* Entity Framework Core
* SQL Server
* Visual Studio

---

## Features

### Create

Add a new vehicle record to the database.

### Read

Display all vehicle records in a DataGrid.

### Update

Modify existing vehicle information.

### Delete

Remove vehicle records from the database.

### Database Initialization

The application automatically creates the database and tables on startup using Entity Framework Core's Code-First approach.

---

## Database Design

### Cars Table

| Column | Data Type              |
| ------ | ---------------------- |
| VIN    | nvarchar (Primary Key) |
| Make   | nvarchar               |
| Model  | nvarchar               |
| Year   | int                    |
| Price  | float                  |

### Entity Model

```csharp
public class Car
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string VIN { get; set; }

    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public double Price { get; set; }
}
```

---

## Project Structure

```text
CarswithSQLDatabase
│
├── Models
│   └── Car.cs
│
├── Data
│   └── CarContext.cs
│
├── Services
│   └── CRUD.cs
│
├── MainWindow.xaml
├── MainWindow.xaml.cs
│
├── App.xaml
└── App.xaml.cs
```

---

## Entity Framework Core Implementation

The application uses a Code-First approach where the database schema is generated from C# classes.

### DbContext

```csharp
public class CarContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
}
```

### Database Creation

```csharp
Records.context.Database.EnsureCreated();
```

This automatically creates the database and required tables if they do not already exist.

---

## Skills Demonstrated

* Object-Oriented Programming (OOP)
* Database Design
* Entity Framework Core
* SQL Server Integration
* CRUD Operations
* WPF User Interface Development
* Data Binding
* Event-Driven Programming
* Code-First Database Development

---

## Future Improvements

* Input Validation
* Search Functionality
* Sorting and Filtering
* Additional Vehicle Attributes
* Asynchronous Database Operations
* MVVM Architecture

---

## Learning Outcomes

This project provided practical experience connecting a desktop application to a relational database using Entity Framework Core. It demonstrates the ability to design entities, configure a database context, perform CRUD operations, and build a functional user interface that interacts with persistent data.

The application serves as a foundational example of full-stack desktop development using the Microsoft technology stack.
