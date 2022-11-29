Console.WriteLine("---10.P8---");
Prog_10_P8.Vehicle vehicleOb = new();
Prog_10_P8.Bus busOb = new ();
Func<Prog_10_P8.Vehicle> del = vehicleOb.CreateVehicle;
del();
del = busOb.CreateBus;
del();

namespace Prog_10_P8
{
    class Vehicle
    {
        Vehicle? vehicle;
        public Vehicle CreateVehicle()
        {
            vehicle = new Vehicle();
            Console.WriteLine("One vehicle is created.");
            return vehicle;
        }
    }
    class Bus : Vehicle
    {
        Bus? bus;
        public Bus CreateBus()
        {
            bus = new Bus();
            Console.WriteLine("One bus is created.");
            return bus;
        }
    }    
}
