using System;

class Program
{
    static void Main (string[] args)
    {
        while (true)
        {
            try
            {    
                Console.WriteLine("Простой калькулятор");
                Console.Write("Введите оператор (+, -, *, /, ^ для возведения в степень, √ для квадратного корня, q для выхода): ");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (op == 'q') // Условие выхода из программы
                {
                    break;
                }

                Console.Write("Введите первое число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                double result = 0;

                if (op == '√')
                {
                    result = Math.Sqrt(num1);
                    Console.WriteLine($"Результат: √{num1} = {result}");
                }
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
                                continue;
                            }
                            break;
                        case '^':
                            result = Math.Pow(num1, num2);
                            break;
                        default:
                            Console.WriteLine("Ошибка: неверный оператор!");
                            continue;
                    }

                    Console.WriteLine($"Результат: {num1} {op} {num2} = {result}");
                }

                    Console.WriteLine(); 
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.ToString()); 
            }
        }
    }
}
