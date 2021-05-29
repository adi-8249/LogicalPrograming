using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1:Fibonacci series program");
            Console.WriteLine("2:PrimeNumber program");
            Console.WriteLine("3:Perfect Number program");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.FibonacciNumber();
                    break;

                case 2:

                    PrimeNumber primenumber = new PrimeNumber();
                    primenumber.PrimeNumberCheck();
                    break;

                case 3:
                    PerfectNumber perfectnumber = new PerfectNumber();
                    perfectnumber.PerfectNumberProgram();
                    break;

            }
        }
    }
}
