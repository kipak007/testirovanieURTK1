using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("Простой калькулятор");
        Console.WriteLine("Поддерживаемые операции: +, -, *, /\n");

        Calculate();

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static void Calculate()
    {
        Console.Write("Введите первое число: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Ошибка: Введено некорректное число!");
            return;
        }

        Console.Write("Введите операцию (+, -, *, /): ");
        string operation = Console.ReadLine();

        if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
        {
            Console.WriteLine("Ошибка: Недопустимая операция!");
            return;
        }

        Console.Write("Введите второе число: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Ошибка: Введено некорректное число!");
            return;
        }

        if (operation == "/" && num2 == 0)
        {
            Console.WriteLine("Ошибка: Деление на ноль!");
            return;
        }

        double result = 0;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
        }

        Console.WriteLine($"\nРезультат: {num1} {operation} {num2} = {result}");
    }
}