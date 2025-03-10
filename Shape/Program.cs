using System;

namespace Shapeee
{
    class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();

            Rectangle rectangle = new Rectangle(1,3);
            Circle circle = new Circle(1);

             shapes.Add(rectangle);
             shapes.Add(circle);

            foreach(Shape shape in shapes)
            {
                Console.WriteLine($"面積は{shape.Area()}です。");
            }

        }
    }
}