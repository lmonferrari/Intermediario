using System;
using System.Threading;

namespace Exercicio1_Secao2
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press enter");

                var keyPressed = Console.ReadKey().Key;
                var stopWatch = new Stopwatch();

                stopWatch.StartTime = stopWatch.Start();

                Console.WriteLine("Press any key to stop!");
                keyPressed = Console.ReadKey().Key;

                if (keyPressed.Equals(ConsoleKey.Escape)) break;

                stopWatch.StopTime = stopWatch.Stop();

                Console.WriteLine("Start time: {0}, Stop time: {1}", stopWatch.StartTime, stopWatch.StopTime);
                Console.WriteLine("time: {0}\n",stopWatch.Difference(stopWatch.StartTime, stopWatch.StopTime));
            }
        }
    }
}


