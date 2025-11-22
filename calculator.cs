using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("Ïðîñòîé êàëüêóëÿòîð");
        Console.WriteLine("Ïîääåðæèâàåìûå îïåðàöèè: +, -, *, /\n");

        Calculate();

        Console.WriteLine("\nÍàæìèòå ëþáóþ êëàâèøó äëÿ âûõîäà...");
        Console.Readline();
    }

    static void Calculate()
    {
        Console.Write("Ââåäèòå ïåðâîå ÷èñëî: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Îøèáêà: Ââåäåíî íåêîððåêòíîå ÷èñëî!");
            return;
        }

        Console.Write("Ââåäèòå îïåðàöèþ (+, -, *, /): ");
        string operation = Console.ReadLine();

        if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
        {
            Console.WriteLine("Îøèáêà: Íåäîïóñòèìàÿ îïåðàöèÿ!");
            return;
        }

        Console.Write("Ââåäèòå âòîðîå ÷èñëî: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Îøèáêà: Ââåäåíî íåêîððåêòíîå ÷èñëî!");
            return;
        }

        if (operation == "/" && num2 == 0)
        {
            Console.WriteLine("Îøèáêà: Äåëåíèå íà íîëü!");
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

        Console.WriteLine($"\nÐåçóëüòàò: {num1} {operation} {num2} = {result}");
    }

}
