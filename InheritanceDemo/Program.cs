using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Phillips");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTV = new TV(false, "Skyworth");
            myTV.SwitchOn();
            myTV.WatchTV();
        }
    }
}