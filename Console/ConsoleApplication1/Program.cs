using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            int a = Convert.ToInt32(Console.ReadLine());
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Pow(a, A));

            Console.ReadKey();
        }
    }
}
