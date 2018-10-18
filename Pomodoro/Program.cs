using Pomodoro.Util;
using System;
using System.Linq;
using System.Threading;

namespace Pomodoro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var tkw = new TimeKeeper(Configuration.WorkTime);
            bool working = true;

            while (working)
            {
                var timeData = tkw.TimeData().Take(1).First();
                if (timeData.Remaining < 0)
                {
                    working = false;
                }

                Console.WriteLine($"Elapsed: {timeData.Elapsed}   - Remaining: {timeData.Remaining}");
                Thread.Sleep(350);
            }

            var tkp = new TimeKeeper(Configuration.PauseTime);
            bool pause = true;

            while (pause)
            {
                var timeData = tkp.TimeData().Take(1).First();
                if (timeData.Remaining < 0)
                {
                    pause = false;
                }

                Console.WriteLine($"PAUSE: Elapsed: {timeData.Elapsed}   - Remaining: {timeData.Remaining}");
                Thread.Sleep(350);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press ANY key to close");
            Console.ReadKey();
        }
    }
}
