// See https://aka.ms/new-console-template for more information
using System;
namespace Vehiclemotor
{
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("トヨタ", 50);
        Motorcycle bike = new Motorcycle("ホンダ", 100);

        car.Move();
        bike.Move();
    }
}
}
