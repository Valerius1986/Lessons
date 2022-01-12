using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int firstValue = 1;
            int secondValue = 11;

            for (; firstValue < 11;)
            {
                m = 0;
                for (; m < firstValue; m++)
                {
                    Console.Write("#");
                }
                for (; m < secondValue; m++)
                {
                    Console.Write(" ");
                }
                Console.Write("\n");
                firstValue++;
            }
            Console.WriteLine();

            m = 0;
            firstValue = 10;
            secondValue = 11;

            for (; firstValue > 0;)
            {
                m = 0;
                for (; m < firstValue; m++)
                {
                    Console.Write("#");
                }
                for (; m < secondValue; m++)
                {
                    Console.Write(" ");
                }
                Console.Write("\n");
                firstValue--;
            }


            m = 0;
             firstValue = 10;
             secondValue = 11;

            for (; firstValue > 0; )
            {
                m = 0;
                for (; m < firstValue; m++)
                {
                    Console.Write(" ");
                }
                for (; m < secondValue; m++)
                {
                    Console.Write("#");
                }
                Console.Write("\n");
                firstValue--;
            }
            Console.WriteLine();

            m = 0;
            firstValue = 1;
            secondValue = 11;

            for (; firstValue < 11;)
            {
                m = 0;
                for (; m < firstValue; m++)
                {
                    Console.Write(" ");
                }
                for (; m < secondValue; m++)
                {
                    Console.Write("#");
                }
                Console.Write("\n");
                firstValue++;
            }
            Console.WriteLine();



        }
    }
}
