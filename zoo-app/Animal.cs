using System;

namespace AnimalInheritanceExample
{
    // 動物を表す基底クラス
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("動物が鳴いています...");
        }
    }
}