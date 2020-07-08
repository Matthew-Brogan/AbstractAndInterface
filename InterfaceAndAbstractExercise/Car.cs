using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractExercise
{
    public class Car : AbstractVehicle, IVehicle
    {
        public void Drive()
        {
            NiceSeats();
            Console.WriteLine("Listen to it purr!");
        }

        public override void NiceSeats()
        {
            Console.WriteLine("Nothing like a nice set of bucketseats!");
        }
    }
}
