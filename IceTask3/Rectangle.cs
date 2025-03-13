using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    class Rectangle: Shape, ICalculateArea
    {
        //Two Properties
        public double Width { get; set; }
        public double Height { get; set; }

        //Constructor
        public Rectangle(string name,double width, double height):base(name)
        {
            Width = width;
            Height = height;

        }
        public double CalculateArea()
        {

            return Width * Height;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Width: {Width}, Height: {Height}, Area: {CalculateArea()}");
        }
    }
    
    }

