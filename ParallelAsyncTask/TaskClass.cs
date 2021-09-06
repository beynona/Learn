using System;
using System.Threading.Tasks;

namespace ParallelAsyncTask
{
    class TaskClass
    {
        public void TaskOne()
        {
            Task task2 = new Task(Fact);
            task2.Start();
            task2.Wait(); //Ожидание конца выполнения задачи

            Task task = new Task(() => Console.WriteLine("First Task"));
            task.Start();

            Task task1 = Task.Run(() => Console.WriteLine("Task run"));
            Console.WriteLine("Wait");

            Task<int> fact = new Task<int>(() => Factorial(5));
            fact.Start();
            Console.WriteLine(fact.Result);


            Task[] mas = new Task[3]
            {
                new Task(() => Console.WriteLine("First mas")),
                new Task(() => Console.WriteLine("Second mas")),
                new Task(() => Console.WriteLine("Third mas"))

            };
            foreach (var item in mas)
            {
                item.Start();
            }
          
        }

        public static int Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }

            return result;
        }

        public void Fact()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
