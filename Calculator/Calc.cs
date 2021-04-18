using System;
using System.IO;

namespace Calculator
{
    class Calc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            File.WriteAllText("C:\test\new.txt", "123456");
        }
   
    }
}
