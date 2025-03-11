using System;

namespace zoo
{
    public abstract class Animal : IAnimal
    {
        public string Name{get; set;}

        public Animal(string name)
        {
            Name = name;        
        }        
        public abstract void MakeSound();
    }
}