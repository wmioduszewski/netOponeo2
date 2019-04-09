using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");




            Console.ReadKey();
        }

        private static List<Person> People()
        {
            return new List<Person>() {
                new Person() { Colors = new List<string>(){"blue", "green"}, Age= 5, Name= "Jake" } ,
                new Person() { Colors = new List<string>(){"orange"}, Age= 1, Name= "Ada" } ,
                new Person() { Colors = new List<string>(){"white", "indigo", "orange"}, Age= 2, Name= "Ada" } ,
                new Person() { Colors = new List<string>(){"black", "magenta", "blue"}, Age= 7, Name= "Mel" } };
        }
    }
}
