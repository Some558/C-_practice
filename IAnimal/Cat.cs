using System;

namespace zoo
{
    public class Cat : Animal
    {
        public Cat() : base(name){}
        public override void MakeSound()
        {
            Console.WriteLine("ニャー");
        }
    }
}