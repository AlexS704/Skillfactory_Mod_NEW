using BenchmarkDotNet.Running;
using System.Diagnostics;

namespace TasksMod12_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Estimate(20);
            Console.ReadKey();

            //var summary = BenchmarkRunner.Run<Testing>();
        }

        static void CreatMatrix(int n)
        {
            var matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    matrix[i][j] = i + j;
                }
            }
        }

        static void Estimate(int n)
        {
            var timer = new Stopwatch();
            var timings = new List<long>();

            timer.Start();

            for (int i = 0; i < n; i++)
            {
                timer.Restart();
                CreatMatrix(10000);
                timer.Stop();

                timings.Add(timer.ElapsedMilliseconds);                
            }

            timings.Sort();

            Console.WriteLine("Отсортированные замеры времени (мс):");
            foreach(var time  in timings)
            {
                Console.WriteLine(time);
            }

            Console.WriteLine($"\nМинимальное время: {timings.First()} мс");
            Console.WriteLine($"Максимальное время: {timings.Last()} мс");
            Console.WriteLine($"Среднее время: {timings.Average()} мс");
        }
    }
}
