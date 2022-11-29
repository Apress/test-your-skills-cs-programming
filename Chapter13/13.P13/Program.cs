Console.WriteLine("---13.P13---");
Console.WriteLine("Normal usage:");

Func<Vehicle> vehicle = Vehicle.GetOneVehicle;
vehicle();
Func<Bus> bus=Bus.GetOneBus;
bus();
Console.WriteLine("Testing covariance:");
vehicle = bus;//Still ok
vehicle();


class Vehicle
{
    public static Vehicle GetOneVehicle()
    {
        Console.WriteLine("Making a vehicle.");
        return new Vehicle();
    }
}
class Bus : Vehicle
{
    public static Bus GetOneBus()
    {
        Console.WriteLine("Making a bus.");
        return new Bus();
    }
}


