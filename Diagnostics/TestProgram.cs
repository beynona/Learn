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
            Console.WriteLine(watch.ElapsedMilliseconds); // 1 секунда = 1000 Миллисекунд
        }
    }
}
