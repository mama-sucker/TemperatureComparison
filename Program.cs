// Module 5.2 TemperatureComparison 
// By Addison Roy

using System;
class TemperaturesComparison
{
    static void Main()
    {
        double[] temperatures = new double[5];

        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                Console.Write("Only enter a number!\n");
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
        }

        Console.WriteLine("\nEntered Temperatures:");
        foreach (var temp in temperatures)
        {
            Console.Write($"{temp}°F ");
        }

        double averageTemperature = GetAverageTemperature(temperatures);

        Console.WriteLine($"\n\nAverage Temperature: {averageTemperature}°F");

        bool isIncreasing = true;
        bool isDecreasing = true;
        for (int i = 1; i < 5; i++)
        {
            if (temperatures[i] <= temperatures[i - 1])
            {
                isIncreasing = false;
            }
            if (temperatures[i] >= temperatures[i - 1])
            {
                isDecreasing = false;
            }
        }

        if (isIncreasing)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (isDecreasing)
        {
            Console.WriteLine("Getting cooler");
        }
        else
        {
            Console.WriteLine("Mixed Bag!");
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

