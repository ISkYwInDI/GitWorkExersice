using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Простой калькулятор");
        Console.Write("Введите оператор (+, -, *, /, ^ для возведения в степень, √ для квадратного корня): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double result = 0;
        if (op == '√')
            result = Math.Sqrt(num1);
        else
        {
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль невозможно!");
                        return;
                    }
                    break;
                case '^':
                    result = Math.Pow(num1, num2);
                    break;
                default:
                    Console.WriteLine("Ошибка: неверный оператор!");
                    return;
            }
            Console.WriteLine($"Результат: {num1} {op} {num2} = {result}");
        }

        if (op == '√')
        {
            Console.WriteLine($"Результат: √{num1} = {result}");
        }
    }
}
