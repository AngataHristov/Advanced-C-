using System;

class FahrenheitToCelsius
{
    public static double ConvertFahrenheitToCelsius(double TemperatureF)
    {
        double TemperatureC = (TemperatureF - 32) * 5 / 9;
        return TemperatureC;
    }
    public static void Main()
    {
        Console.Write("Enter your body temperature in farenheit: ");
        double temperatureF = double.Parse(Console.ReadLine());
        double temperatureC = ConvertFahrenheitToCelsius(temperatureF);
        Console.WriteLine("Your body temperature in celsius is:{0:0.0}", temperatureC);
        if (temperatureC >= 37 || temperatureC <= 36)
        {
            Console.WriteLine("You are ill or undead!");
        }
        Console.WriteLine();
    }
}
