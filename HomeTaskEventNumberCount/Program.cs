using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskEventNumberCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int evenCount = 0;
            int oddCount = 0;

            int evenSum = 0;
            int oddSum = 0;

            Console.WriteLine("Введите первое число диапазона чисел в котором будет подсчитываться количество чётных и нечётных чисел: ");
            int startValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число диапазона: ");
            int limitValue = int.Parse(Console.ReadLine());

            while (startValue < limitValue)
            {
                startValue++;
                if (startValue % 2 == 0)
                {
                    evenCount++;
                    evenSum += startValue;
                }
                else
                {
                    oddCount++;
                    oddSum = oddSum + startValue;
                }
                
            }

            Console.WriteLine("Чётных чисел: " + evenCount);
            Console.WriteLine("Нечётных чисел: " + oddCount);
            Console.WriteLine("Сумма чётных чисел: " + evenSum);
            Console.WriteLine("Сумма нечётных чисел: " + oddSum);
            Console.ReadLine();
        }
    }
}
