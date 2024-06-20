using System;

class TemperatureStats
{
    static void Main()
    {
        Console.WriteLine("Введите количество дней для анализа температуры:");
        int daysCount;
        while (!int.TryParse(Console.ReadLine(), out daysCount) || daysCount <= 0)
        {
            Console.WriteLine("Пожалуйста, введите положительное целое число:");
        }

        double[] temperatures = new double[daysCount];
        for (int i = 0; i < daysCount; i++)
        {
            Console.WriteLine($"Введите температуру для дня {i + 1}:");
            while (!double.TryParse(Console.ReadLine(), out temperatures[i]))
            {
                Console.WriteLine("Пожалуйста, введите корректное значение температуры:");
            }
        }

        double averageTemperature = CalculateAverageTemperature(temperatures);
        double maxTemperature = temperatures.Max();
        double minTemperature = temperatures.Min();

        Console.WriteLine($"Средняя температура за {daysCount} дней: {averageTemperature}");
        Console.WriteLine($"Максимальная температура: {maxTemperature}");
        Console.WriteLine($"Минимальная температура: {minTemperature}");
    }

    static double CalculateAverageTemperature(double[] temperatures)
    {
        double sum = 0;
        foreach (var temp in temperatures)
        {
            sum += temp;
        }
        return sum / temperatures.Length;
    }
}

