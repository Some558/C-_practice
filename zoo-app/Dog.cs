using System;

namespace AnimalInheritanceExample
{
    // Animalクラスを継承したDogクラス
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("ワンワン");
        }
    }
}