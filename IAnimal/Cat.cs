using System;

namespace zoo
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name){}
        public override void MakeSound()
        {
            Console.WriteLine("ニャー");
        }
    }
}