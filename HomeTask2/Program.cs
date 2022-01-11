using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    internal class Converter
    {
        static void Main(string[] args)
        {
            double UsdToRub = 74.2926;
            double USD;

            Console.WriteLine("Введите сумму в USD");
            
            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " USD = " + USD * UsdToRub + " RUB");

        }
    }
}
