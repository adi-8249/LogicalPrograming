using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
  public  class StopWatchProgram
    {
        public void StopWatch()
        {
            Console.WriteLine("Put Start to start your stopwatch!!");
            string startInput = Console.ReadLine();
            DateTime start = DateTime.Now;
            if (startInput == "Start" || startInput == "start" || startInput == "START")
            {
                Console.WriteLine("Stopwatch started....");
                DateTime now = DateTime.Now;
                start = now;
            }
            Console.WriteLine("Press enter to stop watch");
           
            while ((Console.ReadKey(true).Key != ConsoleKey.Enter))
            {
                break;
            }
            DateTime endTime = DateTime.Now;
            TimeSpan duration = start.Subtract(endTime);
            Console.WriteLine($"You have spend Time: {duration.ToString(@"hh\:mm\:ss")}");

        }

    }
}
