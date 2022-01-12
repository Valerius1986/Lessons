using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskArray1v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int evenSum = 0;
            int minNumber = 0;

            // Просим ввести кол-во чисел и сами числа.

            Console.WriteLine("--------------------------------------------------");
            Console.Write("Введите количество чисел:\t");

            int numberElements = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            int[] myArray = new int[numberElements];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите число под индексом {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            // Выводим числа в массиве в обратном порядке.

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Ваши числа в обратном порядке: ");
            Console.WriteLine();
            for (int j = myArray.Length - 1; j >= 0; j--)   // Здесь -1 потому что индексация массивов начинается с 0!!!!
            {
                Console.Write($"Число под индексом {j}:\t");
                Console.WriteLine(myArray[j]);
            }
            Console.WriteLine();

            // Определяем четные числа и выводим их сумму.

            Console.WriteLine("--------------------------------------------------");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    evenSum += myArray[i];
                }
            }
            Console.WriteLine("Сумма четных чисел = " + evenSum);
            
            // Определяем и выводим наименьшее число в массиве

            Console.WriteLine("--------------------------------------------------");

            minNumber = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minNumber)
                {
                    minNumber = myArray[i];
                }

            }

            // или можно проще 

            //Console.Write("Наименьшее число = ");
            //Console.WriteLine(myArray.Min());

            Console.WriteLine("Наименьшее число = " + minNumber);
            Console.WriteLine("--------------------------------------------------");
            Console.ReadLine();
        }
    }
}
