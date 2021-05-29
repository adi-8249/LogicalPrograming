using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        int n, reverse = 0, temp;
        public void ReverseANumber()
        {
           
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                temp = n % 10;
                reverse = reverse * 10 + temp;
                n = n/10;
            }
            Console.Write("Reversed Number: " + reverse);

        }

    }
}
