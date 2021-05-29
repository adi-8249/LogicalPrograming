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
            Console.WriteLine("4:Reverse a number program");
            Console.WriteLine("5:StopWatch program");

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

                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.ReverseANumber();
                    break;

                case 5:
                    StopWatchProgram stopwatch = new StopWatchProgram();
                    stopwatch.StopWatch();
                    break;

                default:
                    Console.WriteLine("Invalid number entered");
                    break;
            }
        }
    }
}
