using System;
using System.Diagnostics;
using System.Threading;

namespace lab3
{
    internal static class Program
    {
        private const int N = 10000;
        private const int K = 10000;
        private const int AmountOfThreads = 2;
        private const int AmountOfIterations = 10;

        private static void Main()
        {
            long totalTime = 0;
            Stopwatch stopWatch = new Stopwatch();

            Console.WriteLine("Without MultiThreading");
            for (int i = 0; i < AmountOfIterations; i++)
            {
                var run = new Process(N, K, 1, 0);

                stopWatch.Restart();
                run.Run();
                stopWatch.Stop();
                totalTime += stopWatch.ElapsedMilliseconds;
                Console.WriteLine("{0} - {1}", i, stopWatch.ElapsedMilliseconds);
            }
            Console.WriteLine("Average Time: {0}", totalTime / AmountOfIterations);

            totalTime = 0;

            Console.WriteLine("\nWith MultiThreading");
            for (int i = 0; i < AmountOfIterations; i++)
            {
                Process[] processes = new Process[AmountOfThreads];
                Thread[] threads = new Thread[AmountOfThreads];
                int start = 0;
                for (int index = 0; index < processes.Length; index++)
                {
                    processes[index] = new Process(N, K, AmountOfThreads, start++);
                    threads[index] = new Thread(processes[index].Run);
                }

                stopWatch.Restart();
                foreach (var variable in threads)
                {
                    variable.Start();
                }
                foreach (var variable in threads)
                {
                    variable.Join();
                }

                stopWatch.Stop();
                totalTime += stopWatch.ElapsedMilliseconds;
                Console.WriteLine("{0} - {1}", i, stopWatch.ElapsedMilliseconds);
            }
            Console.WriteLine("Average Time: {0}", totalTime / AmountOfIterations);

            Console.Read();
        }
    }
}
