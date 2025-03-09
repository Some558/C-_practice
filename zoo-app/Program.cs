using System;

namespace AnimalInheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("一般動物", 5);
            Dog dog = new Dog("ポチ", 3);
            Cat cat = new Cat("シャム", 3);

            animal.MakeSound(); // → 動物が鳴いています...
            dog.MakeSound();    // → ワンワン
            cat.MakeSound();
        }
    }
}

