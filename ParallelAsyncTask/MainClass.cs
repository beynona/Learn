using System;

namespace ParallelAsyncTask
{
    class MainClass
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine($"fact5={AsyncClass.Factorial(5)}");
            Console.WriteLine($"fact1={AsyncClass.Factorial(1)}");
            Console.WriteLine($"fact0={AsyncClass.Factorial(0)}");


        }

        void Tasts()
        {
            Console.WriteLine("StartMain");
            TaskClass task = new TaskClass();
            task.TaskOne();
            Console.WriteLine("StopMain");
        }
    }
}
