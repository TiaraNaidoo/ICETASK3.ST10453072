using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    abstract class Shape
    {
        //Property
        public string Name { get; set; }

        //Constructor
        public Shape(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}
