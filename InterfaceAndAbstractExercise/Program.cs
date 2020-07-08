using System;
using System.Reflection.Metadata;

namespace InterfaceAndAbstractExercise
{
    class Program
    {
        public static object IVheicle { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please select between a honda or suzuki:");
            var userSelection = Console.ReadLine();

            IVehicle carMan = VehicleFactory.GetVehicle(userSelection);
            carMan.Drive();
            
        }
    }
}
