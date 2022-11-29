Console.WriteLine("---13.P16---");
Vehicle vehicle = new();
Bus bus = new();
Console.WriteLine("Normal usage:");
Action<Vehicle> vehicleDel = Sample.ShowVehicle;
vehicleDel(vehicle);
Action<Bus> busDel = Sample.ShowBus;
busDel(bus);
Console.WriteLine("Using contravariance now.");
busDel = vehicleDel;//ok
busDel(bus);
class Vehicle
{
    public virtual void ShowMe()
    {
        Console.WriteLine(" The ShowMe() of the Vehicle is called.");
    }
}
class Bus : Vehicle
{
    public override void ShowMe()
    {
        Console.WriteLine(" The ShowMe() of the Bus is called.");
    }
}
class Sample
{
    internal static void ShowVehicle(Vehicle vehicle)
    {
        vehicle.ShowMe();
    }
    internal static void ShowBus(Bus bus)
    {
        bus.ShowMe();
    }
}
