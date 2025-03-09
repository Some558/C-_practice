using System;

namespace Vehiclemotor
{
class Motorcycle:Vehicle
{
    public Motorcycle(string name, int speed) : base(name, speed) { }

    public override void Move()
    {
        Console.WriteLine($"バイクが時速{this.Speed}kmで走ります。");
    }
}
}