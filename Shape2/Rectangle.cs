using System;

namespace Shape2
{
    class Rectangle : Shape
    {
        public int Width{get; set;}
        public int Height{get; set;}

        public Rectangle(string name, int width, int height) : base(name)
        {            
            Width = width;
            Height = height;
        }
        
        public override double GetArea()
        {
            return Width * Height;
        }
    }
}