using System;

namespace InheritanceDemo
{
    public class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base (isOn, brand){ }
        
        //method to listen to the TV
        public void WatchTV()
        {
            //first check if the radio is on
            if (IsOn)
            {
                //listen to the radio
                Console.WriteLine("Watching the TV");
            }
            else
            {
                //print error message
                Console.WriteLine("TV is switched off, switch it on to watch the TV.");
            }
        }
    }
}