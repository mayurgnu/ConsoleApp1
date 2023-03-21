using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Practicals
{
    public static class ParellelForeach
    {
        //foreach loop runs on a single thread and processing take place sequentially.
        //Parallel.ForEach loop runs on multiple threads and the processing takes place in a parallel manner.
        public static void fnParellelForeach()
        {
            string[] colors = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Parallel.ForEach() Execution...");
            Parallel.ForEach(colors, color =>
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {color}");
                Thread.Sleep(10);
                Console.WriteLine("Thread slept for 10 milisecond(0.01 sec)");
            });
            Console.WriteLine($"Total Secs : {sw.Elapsed.TotalSeconds}");
            Console.WriteLine("ForEach() Execution...");
            foreach (var item in colors)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {item}");
            }
            Console.WriteLine($"Total Secs : {sw.Elapsed.TotalSeconds}");
            Console.ReadLine();
        }
    }
}
