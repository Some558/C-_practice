using System;

namespace electric
{
class Program
{
    static void Main()
    {
    WashingMachine wash = new WashingMachine("wash");
    Refrigerator refri = new Refrigerator("refri");

    wash.TurnOn();
    wash.TurnOff();
    wash.ShowInfo();
    refri.TurnOn();
    refri.TurnOff();
    refri.ShowInfo();
    }
}

}