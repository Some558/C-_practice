using System;

namespace zoo
{
    class Program
    {
        static void Main()
        {
            Dog dog = new Dog("ポチ");
            Cat cat = new Cat("にゃんこ");

            dog.MakeSound();        
            cat.MakeSound();
        }
    }
}