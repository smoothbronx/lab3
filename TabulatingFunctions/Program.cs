/*
 * Ухватов Владислав 22-ИСП-2/1
 * 3.4. Табулирование функций
 * Высокий уровень, 18 вариант (57 страница)
 */

int GetFactorialFromNumber(int number)
{
    var result = 1;
    for (var i = 1; i <= number; i++) result *= i;
    return result;
}

double Calculate(double x, double barrier)
{
    double result = 0;
    for (var k = 1; k <= barrier; k++)
    {
        result += Math.Pow(-1.5, k) * Math.Pow(x, k) / GetFactorialFromNumber(k);
    }

    return result;
}

void Main(double start, double end, double step)
{
    Console.WriteLine("|  x   |  f(x)  |");
    for (var x = start; x <= end; x += step)
    {
        Console.WriteLine($"| {x:F2} | {Calculate(x, 5):F3} |");
    }
}

Main(0.5, 2, 0.15);