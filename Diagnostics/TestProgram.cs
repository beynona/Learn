using System;
using System.Diagnostics;

namespace Diagnostics
{
    class TestProgram
    {
        static void Main(string[] args)
        {

        }
        //Время выполнения куска кода (Пространство имён System.Diagnostics;)
        void TimeCode()
        {
            var watch = new Stopwatch();
            watch = new Stopwatch();
            watch.Start();
            //код
            watch.Stop();

            TimeSpan timeSpan = watch.Elapsed;

            Console.WriteLine("Время работы скрипта: {0}h {1}m {2}s {3}ms", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
        }
    }
}
