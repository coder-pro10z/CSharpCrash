# 🚀 C# Crash Course Project

A beginner-friendly C# console application covering fundamental concepts through simple, readable examples.

---

## 📘 Overview

This single-file crash course project helps you learn:

- ✅ C# Syntax & Data Types
- ✅ Operators (Math, Comparison, Logical)
- ✅ Conditional Statements & Loops
- ✅ Arrays and Collections
- ✅ Methods and Functions
- ✅ Object-Oriented Programming
- ✅ Exception Handling

---

## 🧠 Key Concepts by Section

### 🖨️ `PrintToConsole()`

- Prints "Hello World!" to the console

### 🔤 `VariablesAndDataTypes()`

- Shows use of `int`, `float`, `double`, `decimal`, `char`, `string`, and `bool`

### ➕ `MathOperators()`

- Arithmetic operations: `+`, , , `/`, `%`
- Casting: `int` to `double`
- Division by zero error handling

### 🤝 `ComparisonOperator()`

- `==`, `!=`, `>`, `<`, `>=`, `<=`

### 🔗 `LogicalOperator()`

- Logical operations: `&&`, `||`, `!`

### 🔀 `ConditionalStatements()`

- `if`, `else if`, `else`
- `switch-case`

### 🔁 `Loops()`

- `for`, `while`, `do-while`, `foreach`

### 📦 `Arrays()`

- Declare and access string arrays

### 📚 `Collections()`

- `List<T>`, `HashSet<T>`, `Dictionary<TKey, TValue>`
- `Queue<T>`, `Stack<T>`

### 🧮 `Methods()`

- Creating and calling methods
- Passing parameters

### 👤 `Classes()`

- Create a `Person` class with properties and methods
- Instantiate and use custom objects

### 🚨 `ExceptionHandling()`

- Try/catch block
- Custom exception (`CustomException`)
- `finally` block

---

## 🏗️ How to Run

```bash
bash
Copy
dotnet run

```

Or in **Visual Studio**:

- Open the solution
- Press `Ctrl + F5` to start without debugging

---

## 📂 Project Structure

```
pgsql
Copy
CSharpCrash/
├── Program.cs           → Main file with all concepts
├── Person.cs            → Class definition
├── CustomException.cs   → Custom exception
├── bin/                 → Compiled files
├── obj/                 → Build intermediates
└── README.md            → This file

```

---

## 💡 Tips

- Use `Console.ReadLine()` at the end to keep the terminal open
- Add breakpoints and step through each method to understand flow
- Rename and reorganize sections as you build more examples

---

## 🧭 What's Next?

- ✅ Add File I/O (read/write `.txt`)
- ✅ Integrate ADO.NET or Entity Framework
- ✅ Build a simple WinForms/WPF GUI
- ✅ Convert this to a Web API using ASP.NET Core

---

## 🧭 Polymorphism

Polymorphism, derived from Greek words meaning "many forms", is a fundamental concept in computer science, particularly in object-oriented programming, where it allows objects of different classes to be treated as objects of a common type. This means a single action can be performed in different ways, making code more flexible, reusable, and easier to maintain. 
In essence, polymorphism allows: 
Code Reusability:
You can write generic code that works with various data types or objects, reducing redundancy and making your code more adaptable. 
Flexibility:
Polymorphism allows you to easily add new functionalities or modify existing ones without affecting the entire system, as long as they adhere to the common interface. 
Abstraction:
It allows you to work with objects at a higher level of abstraction, focusing on what they do rather than how they do it, which simplifies code and makes it more understandable. 
Types of Polymorphism: 
Compile-time polymorphism (static polymorphism):
This is achieved through method overloading, where multiple methods with the same name but different parameters exist within the same class. The appropriate method is determined at compile time based on the arguments used in the method call. 
Runtime polymorphism (dynamic polymorphism):
This is achieved through method overriding, where a subclass provides a specific implementation of a method that is already defined in its superclass. The specific method to be executed is determined at runtime based on the actual object type. 
Example:
Consider a base class Animal with a method makeSound(). Subclasses like Dog, Cat, and Bird can inherit from Animal and override the makeSound() method to produce their specific sounds (e.g., Dog says "Woof", Cat says "Meow", Bird says "Tweet"). 
Java

class Animal {
    public void makeSound() {
        System.out.println("Generic animal sound");
    }
}

class Dog extends Animal {
    @Override
    public void makeSound() {
        System.out.println("Woof");
    }
}

class Cat extends Animal {
    @Override
    public void makeSound() {
        System.out.println("Meow");
    }
}
 
When you call animal.makeSound() on an Animal object, the specific implementation of makeSound() based on the actual object's type (e.g., Dog, Cat) will be executed at runtime. 
In summary, polymorphism is a powerful tool in object-oriented programming that allows for code flexibility, reusability, and abstraction, making it easier to develop and maintain complex software systems. 
---
## 👨‍💻 Author

**Praveen Kashyap**

Learning from [Coderversity – C# Crash Course on YouTube](https://www.youtube.com/watch?v=KMsggpCaS10)

---

> 💬 “The best way to learn is by doing. Keep practicing and breaking things!”
>
