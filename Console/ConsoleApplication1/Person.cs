using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person : ICloneable
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
