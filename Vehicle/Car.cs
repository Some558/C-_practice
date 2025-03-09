using System;

namespace Vehiclemotor
{

class Car:Vehicle
{
    public Car(string name, int speed) : base(name,speed){}

    public override void Move()
    {
        Console.WriteLine($"車が時速{this.Speed}kmで走ります。");
    }
}
}
