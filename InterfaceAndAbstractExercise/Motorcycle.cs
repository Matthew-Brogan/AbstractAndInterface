using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractExercise
{
    public class Motorcycle :AbstractVehicle , IVehicle
    {
        public void Drive()
        {
            NiceSeats();
            Console.WriteLine("Rumble,rumble,rumble");
        }

        public override void NiceSeats()
        {
            Console.WriteLine("Dont you love the feel of the wind on your hair?");
        }
    }
}
