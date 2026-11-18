# Library Management System

## Overview

This project is a simple Library Management System built in C# using Object-Oriented Programming (OOP) concepts. The application allows a library to manage books and members, including adding books, borrowing books, returning books, and displaying available books.

## Object-Oriented Programming Principles Used

Object-Oriented Programming is a programming paradigm based on the concept of objects, which can contain data and code. This project demonstrates the four main OOP principles:

### 1. Encapsulation
Encapsulation is the practice of bundling data and methods that operate on that data within a single unit (class). In this project, the `Book`, `Library`, and `Member` classes contain both properties and methods that manage their own data.

### 2. Inheritance
Inheritance allows new classes to be created from existing classes, promoting code reuse and establishing relationships between classes. While this project does not implement inheritance directly, understanding this principle is important for building larger applications.

### 3. Polymorphism
Polymorphism allows different classes to be treated as instances of the same base class. In this project, the `Book` class demonstrates a simple form of polymorphism by overriding the `ToString()` method to provide a custom string representation.

### 4. Abstraction
Abstraction hides complex implementation details and exposes only the necessary functionality. For example, users of the `Library` class can add, remove, and retrieve books without needing to know how the internal book collection is managed.

## Classes

### Book
Represents a library book and stores:
- Title
- Author
- ISBN

### Library
Represents a library and provides functionality to:
- Add books
- Remove books
- Retrieve books
- Display available books

### Member
Represents a library member and provides functionality to:
- Borrow books
- Return books
- Display borrowed books

## Features

- Add books to the library
- Remove books from the library
- Borrow books using ISBN
- Return borrowed books
- View available books
- View borrowed books by member

## How to Run

1. Open the project folder.
2. Navigate to the project directory:

```bash
cd Module5Challenge
