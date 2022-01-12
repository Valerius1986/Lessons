using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool accesAllowed;

            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();

            //if (enteredPassword == storedPassword)
            //{
            //    accesAllowed = true;
            //}
            //else
            //{
            //    accesAllowed = false;
            //}
            //Console.WriteLine(accesAllowed);

            accesAllowed = enteredPassword == storedPassword ? true : false;
            Console.WriteLine(accesAllowed);

            Console.ReadLine();
        }
    }
}
