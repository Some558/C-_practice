using System;

namespace Shape2
{
    class Circle : Shape
    {
        public double Radius{get; set;}
        
        public Circle(string name, int radius) :base(name)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}