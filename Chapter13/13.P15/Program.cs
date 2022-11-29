Console.WriteLine("---13.P15---");

Vehicle vehicle = new();
Bus bus = new();
Console.WriteLine("Normal usage:");
ContraDelegate<Vehicle> vehicleDel = Sample.ShowVehicle;
vehicleDel(vehicle);
ContraDelegate<Bus> busDel = Sample.ShowBus;
busDel(bus);
Console.WriteLine("Testing contravariance now.");
/*
Using general type to derived type.
Following assignment is Ok, if you use 'in' in delegate definition.
Otherwise, you'll receive compile-time error.
*/
busDel = vehicleDel; // OK now
busDel(bus);

// A generic contravariant delegate
delegate void ContraDelegate<in T>(T t);
// A generic non-contravariant delegate
//delegate void ContraDelegate<T>(T t);
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

