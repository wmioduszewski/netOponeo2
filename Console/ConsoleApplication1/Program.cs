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
            //Metoda();

            //var people = People();

            //var result = people.GroupBy(x=>x.Name).Distinct();

            //Person p1 = new Person(){Age = 5, Name = "Filip"};
            //Person p2 = p1.;

            int[] a1 = new[] {1, 2, 3};
            int[] a2 = (int[])a1.Clone();
            a2[0] = 5;

            Console.WriteLine(string.Join(",", a1));
            Console.WriteLine(string.Join(",", a2));

            Console.WriteLine("Przed zmianą");
            //Console.WriteLine(p1.Age);
            //Console.WriteLine(p2.Age);

            //p2.Age = 6;

            Console.WriteLine("Po zmianie");
            Console.ReadKey();
            //Console.WriteLine(p1.Age);
            //Console.WriteLine(p2.Age);


            Console.ReadKey();
        }

        private static int Metoda()
        {
            return Metoda();
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
