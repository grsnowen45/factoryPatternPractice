using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            int wheelCount;
            bool input;
            do
            {


                Console.WriteLine("Enter the number of tires you wish to drive on:");


                input = int.TryParse(Console.ReadLine(), out wheelCount);
            }
            while (input == false);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();






        }
    }
}
