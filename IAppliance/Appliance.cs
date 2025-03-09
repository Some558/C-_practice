using System;

namespace electric
{
    public abstract class Appliance : IAppliance
    {
        protected string Name;

        public Appliance(string name)
        {
            Name = name;
        }
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void ShowInfo();
    }
}