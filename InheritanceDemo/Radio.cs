using System;

namespace InheritanceDemo
{
    public class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand):base(isOn, brand){ }

        //method to listen to the radio
        public void ListenRadio()
        {
            //first check if the radio is on
            if (IsOn)
            {
                //listen to the radio
                Console.WriteLine("Listening to the radio");
            }
            else
            {
                //print error message
                Console.WriteLine("Radio is switched off, switch it on to listen to the radio.");
            }
        }
    }
}