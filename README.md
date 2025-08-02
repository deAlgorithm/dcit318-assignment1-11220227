# DCIT318 Assignment 1 - C# Console Applications

## Overview
This repository contains three C# console applications developed as part of DCIT318 Programming 2 assignment:

1. **Grade Calculator** - Converts numerical grades to letter grades
2. **Ticket Price Calculator** - Calculates movie ticket prices based on age
3. **Triangle Type Identifier** - Determines triangle type based on side lengths

## Project Structure
```
📂 dcit318-assignment1-11220227/
├── 📁 GradeCalculator/
│   ├── 📄 GradeCalculator.cs
│   └── 📄 GradeCalculatorApp.csproj
├── 📁 TicketPriceCalculator/
│   ├── 📄 TicketPriceCalculator.cs
│   └── 📄 TicketPriceCalculatorApp.csproj
├── 📁 TriangleTypeIdentifier/
│   ├── 📄 TriangleTypeIdentifier.cs
│   └── 📄 TriangleTypeIdentifierApp.csproj
├── 📄 RunApps.bat
└── 📄 README.md
```

## Applications Description

### 1. Grade Calculator (`GradeCalculator/GradeCalculator.cs`)
- **Purpose**: Prompts user for a numerical grade (0-100) and displays the corresponding letter grade
- **Grading Scale**:
  - 90 and above: A
  - 80-89: B
  - 70-79: C
  - 60-69: D
  - Below 60: F
- **Features**: Input validation, error handling, clear user interface

### 2. Ticket Price Calculator (`TicketPriceCalculator/TicketPriceCalculator.cs`)
- **Purpose**: Calculates movie ticket price based on customer age
- **Pricing**:
  - Regular price: GHC 10.00
  - Discounted price: GHC 7.00 (for seniors 65+ and children 12 and below)
- **Features**: Age validation, customer type identification, clear pricing display

### 3. Triangle Type Identifier (`TriangleTypeIdentifier/TriangleTypeIdentifier.cs`)
- **Purpose**: Determines triangle type based on the lengths of three sides
- **Triangle Types**:
  - Equilateral: All three sides are equal
  - Isosceles: Two sides are equal
  - Scalene: No sides are equal
- **Features**: Triangle validity checking using triangle inequality theorem, floating-point comparison handling

## How to Run the Applications

### Prerequisites
- .NET 6.0 or later installed on your system
- Command line interface (PowerShell, Command Prompt, or Terminal)

### Compilation and Execution

#### Method 1: Using .NET CLI (Recommended)

1. **Navigate to the project directory**:
   ```powershell
   cd "dcit318-assignment1-11220227"
   ```

2. **Run each application**:
   
   **Grade Calculator**:
   ```powershell
   dotnet run --project .\GradeCalculator\GradeCalculatorApp.csproj
   ```
   
   **Ticket Price Calculator**:
   ```powershell
   dotnet run --project .\TicketPriceCalculator\TicketPriceCalculatorApp.csproj
   ```
   
   **Triangle Type Identifier**:
   ```powershell
   dotnet run --project .\TriangleTypeIdentifier\TriangleTypeIdentifierApp.csproj
   ```

#### Method 2: Using the Batch File (Easy)

Simply double-click `RunApps.bat` and choose which application to run from the interactive menu.

#### Method 3: Using Visual Studio

1. Open Visual Studio
2. Open each project folder individually
3. Open the `.csproj` file for the application you want to run
4. Press F5 or Ctrl+F5 to run

## Testing the Applications

### Grade Calculator Test Cases
- Valid inputs: 95 (A), 85 (B), 75 (C), 65 (D), 45 (F)
- Edge cases: 0, 100, 59.9, 60, 89.9, 90
- Invalid inputs: -5, 105, "abc"

### Ticket Price Calculator Test Cases
- Children: ages 0-12 (GHC 7.00)
- Regular customers: ages 13-64 (GHC 10.00)  
- Senior citizens: ages 65+ (GHC 7.00)
- Invalid inputs: negative ages, non-numeric input

### Triangle Type Identifier Test Cases
- Equilateral: 5, 5, 5
- Isosceles: 5, 5, 8 or 3, 7, 7
- Scalene: 3, 4, 5
- Invalid triangles: 1, 2, 5 (triangle inequality violation)
- Edge cases: very small differences in side lengths

## Code Features

- **Input Validation**: All applications include robust input validation
- **Error Handling**: Try-catch blocks and user-friendly error messages
- **Clean Code**: Well-commented, organized with helper methods
- **User Experience**: Clear instructions and formatted output
- **Constants**: Used for maintainable code (prices, age limits)

## Student Information
- **Student ID**: 11220227
- **Course**: DCIT318 - Programming 2
- **Assignment**: Assignment 1 - C# Console Applications

## Notes
- All applications are console-based and interactive
- Input validation ensures robust user experience
- Code follows C# naming conventions and best practices
- Each application is self-contained and can run independently