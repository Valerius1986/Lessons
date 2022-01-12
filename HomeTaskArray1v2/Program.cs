using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskArray1v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int evenSum = 0;

            Console.WriteLine("--------------------------------------------------");
            Console.Write("Введите количество чисел:\t");

            int numberElements = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            int[] myArray = new int[numberElements];
            for (int i = 0; i < numberElements; i++)
            {
                Console.Write($"Введите число под индексом {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Вы ввлели: ");
            //for (int i = 0;i < myArray.Length;i++)
            //{
            //    Console.Write(myArray[i] + ", ");
            //}
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Ваши числа в обратном порядке: ");
            Console.WriteLine();
            for (int j=numberElements-1; j>=0; j--)
            {
                Console.Write($"Число под индексом {j}:\t");
                Console.WriteLine(myArray[j]);
            }
            Console.WriteLine();
            
            Console.WriteLine("--------------------------------------------------");
            for (int i = 0; i < myArray.Length; i++)
            {
               if (myArray[i] % 2 == 0)
                {
                    evenSum += myArray[i];
                }
            }
            Console.WriteLine("Сумма четных чисел = " + evenSum);
            //Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            Console.Write("Наименьшее число = ");
            Console.WriteLine(myArray.Min());
            Console.WriteLine("--------------------------------------------------");
            Console.ReadLine();
        }
    }
}
