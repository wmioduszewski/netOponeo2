using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Person : ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public List<string> Colors { get; set; }

        public override string ToString()
        {
            return Name + " is " + Age + " years old";
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
