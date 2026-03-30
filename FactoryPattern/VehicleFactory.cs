namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tires)
        {
            if (tires == 2)
            {
                return new Motorcycle();
            }
            else
            {
                return new Car();
            }
        }
    }
}