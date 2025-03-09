using System;

namespace electric
{
    public class Refrigerator : Appliance
    {
        public Refrigerator(string name) : base(name)
        {
            
        }
        public override void TurnOn()
        {
            Console.WriteLine($"{this.Name}を起動しました" );
        }
        public override void TurnOff()
        {
            Console.WriteLine($"{this.Name}を停止しました");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"これは{this.Name}です");
        }
    }
}