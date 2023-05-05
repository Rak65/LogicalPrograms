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
            Console.WriteLine("Enter any key to start the StopWatch : ");
            Console.ReadKey();
            stopWatch.Start();
            Console.WriteLine("Enter any key to stop the StopWatch : ");
            Console.ReadKey();  
            //Thread.Sleep(10000);
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine("Elapsed Time : " + elapsedTime);
            Console.ReadKey();
        }
    }
}