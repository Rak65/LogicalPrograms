using System;
using System.Diagnostics;
using System.Threading;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Enter 1 to start the StopWatch : ");
            int startTime =Convert.ToInt32 ( Console.ReadLine());
            if (startTime == 1)
            {
                stopWatch.Start();
                Console.WriteLine("Enter 1 to stop the StopWatch : ");
                int stopTime = Convert.ToInt32(Console.ReadLine());
                if (stopTime == 1)
                {
                    //Thread.Sleep(10000);
                    stopWatch.Stop();

                    // Get the elapsed time as a TimeSpan value.
                    TimeSpan ts = stopWatch.Elapsed;

                    // Format and display the TimeSpan value.
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);
                    if (startTime == 1 && stopTime == 1)
                    {
                        Console.WriteLine("Elapsed Time : " + elapsedTime);
                    }
                }
                else
                    Console.WriteLine("Try Again.");
            }
            else
                Console.WriteLine("Try again.");
            Console.ReadKey();
        }
    }
}