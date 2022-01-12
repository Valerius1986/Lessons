using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneDimensionalArray
{
    /*
     * Массивы
     * 
     * Одномерные массивы
     * 
     * Тип_элементов_массива [] имя_массива;
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;

            myArray = new int[5];

            myArray[1] = 3;
            myArray[0] = 10;

            int a = myArray[0];

            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
