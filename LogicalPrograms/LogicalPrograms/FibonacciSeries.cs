using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        int number1 = 0;
        int number2 = 1;
        int number3;
        int i;
        int numberLength;
        public void FibonacciNumber()
        {
            Console.Write("Enter a number :");
            numberLength = int.Parse(Console.ReadLine());
            Console.Write(number1 + " " + number2 + " ");//only printing the value of number1 and number2 here    
            for (i = 0; i < numberLength; i++)
            {
                number3 = number1 + number2;
                Console.Write(number3 + " ");
                number1 = number2;
                number2 = number3;

            }
        }
    }
}
