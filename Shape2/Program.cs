using System;

namespace Shape2
{
    class Program{

    static void Main()
    {
        Circle circle = new Circle("マルコ", 2);
        Rectangle rectangle = new Rectangle("ちょほけ", 2, 3);

        Console.WriteLine(circle.GetArea());
        Console.WriteLine(rectangle.GetArea());

    }
    }
    
}