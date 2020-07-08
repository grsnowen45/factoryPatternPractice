using System;
namespace FactoryPattern
{
    public class UltraTank : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("BY DEFAULT YOU HAVE BEEN GIVEN AN ULTRA TANK!");
        }

    }
}
