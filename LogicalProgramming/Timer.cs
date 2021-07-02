using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
//Adding using System.Diagnostics inorder to use StopWatch class

namespace LogicalProgramming
{
    class Timer
    {
        public static void StopWatch ()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //T his takes 10 seconds to finish.
            Console.WriteLine("Start time");
            for (int i = 0; i < 1000; i++)
            {
              

                System.Threading.Thread.Sleep(10);

                
            }

            // Stop.
            stopwatch.Stop();
            Console.WriteLine("Stop time");

           

            // Write hours, minutes and seconds.
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}
