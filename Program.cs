// Module 5.2 TemperatureComparison 
// By Addison Roy

using System;

class TemperatureAnalyzer
{
    static void Main()
    {
        double[] temperatures = new double[5];
        double previousTemperature = double.MaxValue; // Changed to Maximum Value

        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                Console.Write("Only enter the number!\n");
                Console.Write($"Enter temperature (Fahrenheit) {i + 1} (-30 to 130): ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out temperatures[i]) && temperatures[i] >= -30 && temperatures[i] <= 130)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid temperature. Please enter a temperature between -30 and 130.");
                }
            }

            if (temperatures[i] < previousTemperature) 
            {
                previousTemperature = temperatures[i];
            }
        }

        Console.WriteLine("\nEntered Temperatures:");
        foreach (var temp in temperatures)
        {
            Console.Write($"{temp}°F ");
        }

        double averageTemperature = GetAverageTemperature(temperatures);

        Console.WriteLine($"\n\nAverage Temperature: {averageTemperature}°F");

        if (previousTemperature != double.MaxValue) 
        {
            Console.WriteLine("Getting Cooler");
        }
        else if (averageTemperature != temperatures[0]) 
        {
            Console.WriteLine("Getting Warmer");
        }
        else
        {
            Console.WriteLine("No change in temperature");
        }
    }

    static double GetAverageTemperature(double[] temperatures)
    {
        double sum = 0;

        foreach (var temp in temperatures)
        {
            sum += temp;
        }

        return sum / temperatures.Length;
    }
}

}
