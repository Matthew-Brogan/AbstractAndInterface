using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string name)
        {
            switch (name)
            {
                case "honda":
                    return new Car();
                    break;
                default :
                    return new Motorcycle();
                    break;

            }
        }
    }
}
