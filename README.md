# QuantumProject

## Description

This project is a “Quantum Warehouse” simulation developed using Object-Oriented Programming (OOP) principles across different programming languages (C#, Java, JavaScript, Python). The project models abstract concepts such as `QuantumObject`, `AntiMatter`, and `DarkMatter` through classes and manages them via a console-based application.

The main goal is to compare the implementations of the same OOP concepts (inheritance, polymorphism, interfaces, and exception handling) across different programming languages.

## Features

- **Multi-Language Application:** C#, Java, JavaScript ve Python dillerinde aynı projenin paralel olarak geliştirilmesi.
- **Object-Oriented Modeling:** Concepts such as `AntiMatter`, `DarkMatter` and `DataPacket` are derived from the `QuantumObject` base class through inheritance.
- **Interactive Console Interface:** A menu-driven control panel for managing the “Quantum Warehouse”.
- **Polymorphism:** The `Analyze()` method exhibits different behaviors for each object type.
- **Interface Usage:** The `ICritical` interface provides special abilities such as Emergency Cooling to specific objects.
- **Custom Exception Handling:** Critical error states in program flow are handled using `QuantumCollapseException`.

## Getting Started

1.  Clone the repository:
    ```bash
    git clone https://github.com/your-kullaniciadi/QuantumProject.git
    ```
2.  Navigate to the directory of the language you are interested in:
    *   `cd csharp`
    *   `cd java`
    *   `cd javascript`
    *   `cd python`

## Usage

Each language directory contains its own set of examples and instructions. Below are the general execution guidelines for each language:

### C#

To run the C# project, navigate to the `csharp` directory and use the .NET CLI:

```bash
cd csharp
dotnet run
```

### Java

To compile and run the Java project, navigate to the `java` directory and use the `javac` and `java` commands:

```bash
cd java
javac *.java
java Program
```

### JavaScript

To run the JavaScript file using Node.js, navigate to the `javascript` directory and use the `node` command:

```bash
cd javascript
node Main.js
```

### Python

To run the Python file, navigate to the `python` directory and use the `python` interpreter:

```bash
cd python
python main.py
```

## Project Structure

```
QuantumProject/
│
├── csharp/
│     - AntiMatter.cs
│     - ICritical.cs
│     - DarkMatter.cs
│     - QuantumCollapseException.cs
│     - QuantumObject.cs
│     - DataPacket.cs
│     - Program.cs
│
├── java/
│     - AntiMatter.java
│     - ICritical.java
│     - DarkMatter.java
│     - QuantumCollapseException.java
│     - QuantumObject.java
│     - DataPacket.java
│     - Main.java
│
├── javascript/
│     - AntiMatter.js
│     - DarkMatter.js
│     - QuantumCollapseException.js
│     - QuantumObject.js
│     - DataPacket.js
│     - Main.js
│
├── python/
│     - AntiMatter.py
│     - ICritical.py
│     - DarkMatter.py
│     - QuantumCollapseException.py
│     - QuantumObject.py
│     - DataPacket.py
│     - main.py
│
└── README.md
```
