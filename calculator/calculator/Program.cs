using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Виберіть режим роботи калькулятора:");
                Console.WriteLine("1 - Стандартний");
                Console.WriteLine("2 - Інженерний");
                Console.WriteLine("Для виходу введіть 'exit'");

                string choice = Console.ReadLine();
                if (choice?.ToLower() == "exit")
                    break;

                switch (choice)
                {
                    case "1":
                        StandardMode();
                        break;
                    case "2":
                        EngineeringMode();
                        break;
                    default:
                        Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }

        private static void StandardMode()
        {
            var calc = new StandardCalculator();
            try
            {
                Console.WriteLine("Введіть перше число:");
                double operand1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Введіть друге число:");
                double operand2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Виберіть операцію (+, -, *, /):");
                string operation = Console.ReadLine();

                calc.SetOperands(operand1, operand2);

                double result = operation switch
                {
                    "+" => calc.Add(),
                    "-" => calc.Subtract(),
                    "*" => calc.Multiply(),
                    "/" => calc.Divide(),
                    _ => throw new InvalidOperationException("Невідома операція.")
                };

                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        private static void EngineeringMode()
        {
            var calc = new EngineeringCalculator();
            try
            {
                Console.WriteLine("Введіть число (в градусах) для операції:");
                double operand1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Виберіть операцію:");
                Console.WriteLine("1 - exp(a) (-5 ≤ a ≤ 5)");
                Console.WriteLine("2 - sin(a) в градусах");
                Console.WriteLine("3 - cos(a) в градусах");

                string operation = Console.ReadLine();

                calc.SetOperands(operand1, 0);

                double result = operation switch
                {
                    "1" => calc.Exp(),
                    "2" => calc.SinInDegrees(),
                    "3" => calc.CosInDegrees(),
                    _ => throw new InvalidOperationException("Невідома операція.")
                };

                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
