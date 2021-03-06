using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "circle";
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"{Name} has a radius of {Radius}");
        }
    }
}
