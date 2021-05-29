using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1:Fibonacci series program");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.FibonacciNumber();
                    break;
            }
        }
    }
}
