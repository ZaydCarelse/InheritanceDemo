using System;

namespace InheritanceDemo
{
    public class ElectricalDevice
    {
        //boolean to determine the state of the TV
        public bool IsOn { get; set; }
        //string for the brand of the TV
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }
        
        //switch on the TV
        public void SwitchOn()
        {
            IsOn = true;
        }
        //switch off the TV
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}