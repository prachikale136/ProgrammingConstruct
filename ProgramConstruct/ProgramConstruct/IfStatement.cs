using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConstruct
{
    internal class IfStatement
    {
        public static void CheckInteger()
        {
            Console.WriteLine("Enetr the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Both integer are equal");
            }
            else
            {
                Console.WriteLine("Both number are not equal");
            }
        }

        public static void CheckEvenOrOdd() 
        {
            Console.WriteLine("Ener the number to check");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("number is Even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }

    }
}
