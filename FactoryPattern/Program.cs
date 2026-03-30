namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have?");
            int tires = int.Parse(Console.ReadLine());

            IVehicle vehicle = VehicleFactory.GetVehicle(tires);

            vehicle.Drive();
        }
    }
}