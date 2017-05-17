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

                stopWatch.Start(DateTime.Now);

                Console.WriteLine("Press any key to stop!");
                keyPressed = Console.ReadKey().Key;

                if (keyPressed.Equals(ConsoleKey.Escape)) break;

                stopWatch.Stop(DateTime.Now);

                Console.WriteLine("Stop - start = {0}\n", stopWatch.Difference());
            }
        }
    }
}


