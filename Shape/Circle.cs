using System;

namespace Shapeee
{
    class Circle : Shape
    {
        // Radiusは半径
        public double Radius{get; set;}

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}