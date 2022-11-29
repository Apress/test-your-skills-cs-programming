Console.WriteLine("---13.P14---");

Bus bus1 = new Bus();
Bus bus2 = new Bus();
//Creating a bus list
//Remember that List<T> implements IEnumerable<T>
List<Bus> busList = new();
busList.Add(bus1);
busList.Add(bus2);

IEnumerable<Vehicle> vehicleList = busList;
foreach (Vehicle vehicle in vehicleList)
{
    vehicle.Describe();
}
class Vehicle
{
    public virtual void Describe()
    {
        Console.WriteLine($"A vehicle is ready with hash code {GetHashCode()}");
    }
}
class Bus : Vehicle
{
    public override void Describe()
    {
        Console.WriteLine($"A bus is ready with hash code {GetHashCode()}");
    }
}
