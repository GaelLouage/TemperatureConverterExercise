using System.Reflection.Metadata.Ecma335;
using System.Text;
using TemperatureConverterExercise.Helpers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => 
{
    var celsius = 25;
    var fahrenheit = 77;

    var toFahrenheit = Temperature.CelsiusToFahrenheit(celsius);
    var toCelsius = Temperature.FahrenheitToCelsius(fahrenheit);
    var sb = new StringBuilder();
    sb.AppendLine($"25° celsius to fahrenheit: {toFahrenheit}F");
    sb.AppendLine($"77F fahrenheit to celsius: {toCelsius}°");
    return sb.ToString();

});

app.Run();
