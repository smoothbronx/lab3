/*
 * Ухватов Владислав 22-ИСП-2/1
 * 3.1. Оператор цикла с параметром
 * Высокий уровень, 18 вариант (42 страница)
 */

string GetNotNullableVariable(string variableName)
{
    while (true)
    {
        Console.Write($"Enter {variableName} value: ");
        var input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
            return input;
        }

        Console.WriteLine("The entered value cannot be null.");
    }
}

double GetDoubleFromCommandLine(string variableName = "variable")
{
    while (true)
    {
        var stringNumber = GetNotNullableVariable(variableName);

        if (double.TryParse(stringNumber, out var parsed)) return parsed;

        Console.WriteLine("The entered number must be of type double.");
    }
}

double Calculate(double k)
{
    double multiply = 1;
    for (var j = -1; j <= k; j++)
    {
        double summa = 0;
        for (var i = j; i <= k + 3; i++)
        {
            summa += Math.Pow(Math.Abs(i - 5), 0.25) / Math.Abs(i - 7);
        }

        multiply *= (j - Math.Pow(j, 2)) * j / (j + 14) * summa;
    }

    return multiply;
}

var k = GetDoubleFromCommandLine("<k>");
Console.WriteLine(Calculate(k));
