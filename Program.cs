using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(2), new Rectangle(4, 5) };

            foreach(Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine($"Area of {s.Name} is { s.GetArea()}");

                Circle testCircle = s as Circle;
                if (testCircle == null)
                {
                    Console.WriteLine("This isn't a circle");
                }

                if (s is Circle)
                {
                    Console.WriteLine("This isn't a rectangle");
                }

                Console.WriteLine();

                object circ1 = new Circle(4);
                Circle circ2 = (Circle)circ1;
                Console.WriteLine($"Area of {circ2.Name} is { circ2.GetArea()}");
            }

            Console.ReadLine();
        }
    }
}
