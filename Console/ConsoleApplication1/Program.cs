using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            Person person = People().FirstOrDefault();

            if (person.Age > 6)
            {
                Console.WriteLine("Person is older than 6");
            }
            else
            {
                Console.WriteLine("Person is younger than 6 (or 6)");
            }

            // person w JSON
            string result = JsonConvert.SerializeObject(person);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        private static List<Person> People()
        {
            Console.WriteLine("Wczytuję dane");

            var res = new List<Person>() {
                new Person() { Colors = new List<string>(){"white", "green"}, Age= 5, Name= "Jake" },
                new Person() { Colors = new List<string>(){"orange"}, Age= 1, Name= "Ada" } ,
                new Person() { Colors = new List<string>(){"orange"}, Age= 1, Name= "Ada" } ,
                new Person() { Colors = new List<string>(){"white", "indigo", "orange"}, Age= 2, Name= "Ada" } ,
                new Person() { Colors = new List<string>(){"black", "magenta", "blue"}, Age= 7, Name= "Mel" } };
            Console.WriteLine("Koniec wczytywania");

            return res;

        }
    }
}
