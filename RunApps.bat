@echo off
echo ===============================================
echo    DCIT318 Assignment 1 - Console Applications
echo ===============================================
echo.

:menu
echo Choose an application to run:
echo 1. Grade Calculator
echo 2. Ticket Price Calculator  
echo 3. Triangle Type Identifier
echo 4. Exit
echo.
set /p choice="Enter your choice (1-4): "

if "%choice%"=="1" (
    echo.
    echo Running Grade Calculator...
    echo.
    dotnet run --project ".\GradeCalculator\GradeCalculatorApp.csproj"
    echo.
    echo Returning to main menu...
    echo.
    goto menu
)

if "%choice%"=="2" (
    echo.
    echo Running Ticket Price Calculator...
    echo.
    dotnet run --project ".\TicketPriceCalculator\TicketPriceCalculatorApp.csproj"
    echo.
    echo Returning to main menu...
    echo.
    goto menu
)

if "%choice%"=="3" (
    echo.
    echo Running Triangle Type Identifier...
    echo.
    dotnet run --project ".\TriangleTypeIdentifier\TriangleTypeIdentifierApp.csproj"
    echo.
    echo Returning to main menu...
    echo.
    goto menu
)

if "%choice%"=="4" (
    echo.
    echo Thank you for using DCIT318 Assignment 1 Applications!
    echo Goodbye!
    pause
    exit /b
)

echo Invalid choice. Please enter 1, 2, 3, or 4.
echo.
goto menu
