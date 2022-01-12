using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[5];

            Console.WriteLine("Введите числа: ");

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = int.Parse(Console.ReadLine());
            }
            //Console.ReadLine();

            Console.WriteLine("Числа которые вы ввели: ");

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write(numbersArray[i] + ", ");
            }
            Console.ReadLine();

            Console.WriteLine("Числа которые вы ввели в обратном порядке: ");

            for (int i = numbersArray.Length; i > 0; i--)
            {
                Console.Write(numbersArray[i] + ", ");
            }
            Console.ReadLine();


        }
    }
}
