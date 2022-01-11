using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCalculator1
{
    internal class ProgramCalculator
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string operation;

                try
                {
                    Console.WriteLine("Введите первое число:");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Это не число число!");
                    Console.WriteLine("Я не могу работать с этими символами.");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Введите значение: (+, -, *, /):");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine("= " + (firstValue + secondValue));
                        break;
                    case "-":
                        Console.WriteLine("= " + (firstValue - secondValue));
                        break;
                    case "*":
                        Console.WriteLine("= " + (firstValue * secondValue));
                        break;
                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine("Ошибка! На 0 делить нельзя");
                        else
                            Console.WriteLine("= " + (firstValue / secondValue));
                        break;
                    default:
                        Console.WriteLine("Неизвестное значение!");
                        Console.WriteLine("Допустимые значения (+, -, *, /):");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Для продолжения нажмите любую клавишу...");
                Console.ReadLine();
            }
        }
    }
}
