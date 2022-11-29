Console.WriteLine("---10.P9---");

Prog_10_P9.Vehicle myVehicle = new();
Prog_10_P9.Bus myBus = new();
// Normal case
Action<Prog_10_P9.Bus> del = Prog_10_P9.Bus.ShowBus;
del(myBus);
// Testing contravariance
del = Prog_10_P9.Vehicle.ShowVehicle;
del(myBus);

namespace Prog_10_P9
{
    class Vehicle
    {
        public static void ShowVehicle(Vehicle myVehicle)
        {
            Console.WriteLine("ShowVehicle is called.");
            Console.WriteLine("This is a generic vehicle.\n");
        }
    }
    class Bus : Vehicle
    {
        public static void ShowBus(Bus myBus)
        {
            Console.WriteLine("ShowBus is called.");
            Console.WriteLine("This is a bus.\n");
        }
    }    
}

