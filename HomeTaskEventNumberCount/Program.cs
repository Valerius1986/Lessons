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
            int count =0;
            int evenCount = 0;
            int oddCount = 0;

            Console.WriteLine("Введите диапазон чисел в котором будет подсчитываться количество чётных и нечётных чисел: 12");
            int limit = int.Parse(Console.ReadLine());

            while (count < limit)
            {
                count++;
                if (count % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
                
            }

            Console.Clear();
            Console.WriteLine("В диапазоне чисел от 0 до " + limit + ".");
            Console.WriteLine("Чётных чисел: " + evenCount);
            Console.WriteLine("Нечётных чисел: " + oddCount);
        }
    }
}
