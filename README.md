# Temperature Converter Exercise

## Overview

This project is a simple temperature converter utility implemented in C#. It provides methods to convert temperatures between Celsius and Fahrenheit. The project includes a minimal ASP.NET Core web application that demonstrates the conversion functionality.

## Features

- **Celsius to Fahrenheit Conversion**: Convert a temperature from Celsius to Fahrenheit.
- **Fahrenheit to Celsius Conversion**: Convert a temperature from Fahrenheit to Celsius.
- **Web API**: A simple web API endpoint that returns sample temperature conversions.

## Conversion Formulas

- **Celsius to Fahrenheit**: F =  (celsius * 9 / 5) + 32
- **Fahrenheit to Celsius**: C =  (fahrenheit - 32) * 5 / 9

## Project Structure

- `TemperatureConverterExercise/Helpers/Temperature.cs`: Contains the static `Temperature` class with conversion methods.
- `Program.cs`: The entry point of the application, hosting a simple ASP.NET Core web API.
- `Startup.cs` (if applicable): Configuration for the web API (in this case, most configurations are directly in `Program.cs`).

## Usage

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/TemperatureConverterExercise.git
   cd TemperatureConverterExercise

    Run the application:

    bash

dotnet run

Access the API:

    Open your browser and navigate to http://localhost:5000/ to see the sample temperature conversions.
