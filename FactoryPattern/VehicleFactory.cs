using System;
namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            switch (wheelCount)
            {
                case 2:
                    return new SpaceBike();
                case 4:
                    return new SuperTruck();
                default:
                    return new UltraTank();
            }




        }

            



    }
}
