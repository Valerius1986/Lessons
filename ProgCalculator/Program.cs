using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string operation;

                Console.WriteLine("Введите первое число:");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите значение опеции над этими числами (+, -, *, /):");
                operation = Console.ReadLine();

                Console.WriteLine("Введите второе число:");
                secondValue = double.Parse(Console.ReadLine());

                if (operation == "+")
                {
                    Console.WriteLine("= " + (firstValue + secondValue));
                }
                else if (operation == "-")
                {
                    Console.WriteLine("= " + (firstValue - secondValue));
                }
                else if (operation == "*")
                {
                    Console.WriteLine("= " + (firstValue * secondValue));
                }
                else if (operation == "/")
                {
                    if (secondValue == 0)
                        Console.WriteLine("Ошибка! На 0 делить нельзя");
                    else
                        Console.WriteLine("= " + (firstValue / secondValue));
                }
                else
                {
                    Console.WriteLine("Неизвестное значение!");
                    Console.WriteLine("Допустимые значения (+, -, *, /):");
                }
                Console.ReadLine();
            }
        }
    }
}
