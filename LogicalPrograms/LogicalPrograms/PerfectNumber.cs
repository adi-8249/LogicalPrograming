using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        int number, sum = 0, MaxNumber;
        public void PerfectNumberProgram()
        {
            Console.Write("enter the Number");
            number = int.Parse(Console.ReadLine());
            MaxNumber = number;


            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == MaxNumber)
            {
                Console.WriteLine(" Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Entered number is not a perfect number");
                Console.ReadLine();
            }
        }

    }
}
