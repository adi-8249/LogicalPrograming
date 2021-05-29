using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
   public class PrimeNumber
    {
        int n, i, NumberLength = 0, temp = 0;
        public void PrimeNumberCheck()
        {
            
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            NumberLength = n / 2;
            for (i = 2; i <= NumberLength; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    temp = 1;
                }
            }
            if (temp == 0)
                Console.Write("Number is Prime.");
        }
    }
}
