# **Hi 👋, There**

------------
### **This is an explanation of what I did here for the test at Codi....**

The project was created using .NET 5, with C#. Basically I divided the program in the Logic folder in two main sections:

## Decisions

After reading and interpreting the problem, I decided to implement a Factory Design Pattern that will allow the program to handle the calculation of more shape areas more easily, due that the program will rely on abstractions and not strict implementations; also, I decided to create a Shape Base Class, that will contain a Dictionary of values and contants, these properties will allow the class to make common calculations among the shapes, so we can only override the strictly necessary methods.

## Folder Structure

### 1. Business Logic

This section contains interfaces and implementations of the main logic of the program, containing also the implementation of the Factory Design Patter.

### 2. Domain

This section Contains the Response Dtos, base classes and helpers.

**:star: .Net 5**
**:star: C#**
**:star: Factory Design Pattern**
**:star: Basic Unit Testing**