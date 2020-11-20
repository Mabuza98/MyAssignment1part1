using System;
using System.Linq;
namespace Assignment1.p1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputString = "I submited this assignment a long time go";
            string reversedString = string.Empty;

            for (int counter = inputString.Length - 1; counter >= 0; counter--)
            {
                reversedString = reversedString + inputString[counter];

            }
            Console.WriteLine(reversedString);

        }
    }
}