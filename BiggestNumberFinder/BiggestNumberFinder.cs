using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFinder
{
    public class BiggestNumberFinder
    {
        public static int FindMax(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber)
        {
            Console.Write("Enter first number: ");
            int number1 = Int32.Parse(Console.ReadLine());    
            Console.Write("Enter second number: ");
            int number2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int number3 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int number4 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            int number5 = Int32.Parse(Console.ReadLine());
            return Math.Max(Math.Max(Math.Max(number1, number2), Math.Max(number3, number4)), number5);
        }
    }
}
