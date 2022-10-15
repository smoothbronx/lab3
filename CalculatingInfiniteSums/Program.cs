/*
 * Ухватов Владислав 22-ИСП-2/1
 * 3.3. Вычисление бесконечных сумм
 * 18 вариант (50 страница)
 */
 
string GetNotNullableVariable(string variableName)
{
    while (true)
    {
        Console.Write($"Enter {variableName} value: ");
        var input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input)) return input;

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

uint GetUintFromCommandLine(string variableName = "variable")
{
    while (true)
    {
        var stringNumber = GetNotNullableVariable(variableName);

        if (uint.TryParse(stringNumber, out var parsed)) return parsed;

        Console.WriteLine("The entered number must be of type uint.");
    }
}

double Calculate(double x, uint amount)
{
    double result = 0;
    for (var iteration = 1; iteration <= amount; iteration++)
    {
        var lastNumber = 1 + (iteration - 1) * 2;
        result += Math.Cos(2 * iteration * x) / (lastNumber * (lastNumber + 2));
    }

    return result;
}

var n = GetUintFromCommandLine("<n>");
var x = GetDoubleFromCommandLine("<x>");

Console.WriteLine(Calculate(x, n).ToString("F4"));