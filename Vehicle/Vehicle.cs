using System;

namespace Vehiclemotor
{
class Vehicle
{
    protected string Name{get;set;}
    protected int Speed{get;set;}

    public Vehicle(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public virtual void Move()
    {
        Console.WriteLine("乗り物が走ります。");
    }
}
}