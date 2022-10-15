/*
 * Ухватов Владислав 22-ИСП-2/1
 * 3.2. Оператор цикла с предусловием и постусловием
 * Высокий уровень, 18 вариант (48 страница)
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

decimal GetDecimalFromCommandLine(string variableName = "variable")
{
    while (true)
    {
        var stringNumber = GetNotNullableVariable(variableName);

        if (decimal.TryParse(stringNumber, out var parsed)) return parsed;

        Console.WriteLine("The entered number must be of type decimal.");
    }
}

// Месячный рост цен
const double inflation = 1.3;

// Накопления студента
var savings = GetDecimalFromCommandLine("<S>");

// Ежемесячная стипендия студента
var scholarship = GetDecimalFromCommandLine("<A>");

// Расходы на проживание в первый месяц
var expenses = GetDecimalFromCommandLine("<B>");

// Количество месяцев, которые прожил студент
var month = 0;

do
{
    // Доход студента в месяц с учетом расходов
    var profit = scholarship - expenses * (decimal) Math.Pow(inflation, month);
    
    if (savings + profit < 0) break;
    
    savings += profit;
    month++;
} while (true);

Console.WriteLine($"\nResult: {month}");