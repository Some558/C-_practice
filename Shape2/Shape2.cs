using System;

namespace Shape2
{
    abstract class Shape
    {
        public string Name{get; set;}

        public Shape(string name)
        {
            Name = name;
        }

        public abstract double GetArea();

    }
}