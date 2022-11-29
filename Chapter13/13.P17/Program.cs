Console.WriteLine("---13.P17---");
Bus aBus=new Bus();
Vehicle aVehicle=new Vehicle(); 
IContraInterface<Vehicle> vehicle = new Implementor<Vehicle>();
Console.WriteLine(vehicle);
vehicle.Display(aVehicle);

IContraInterface<Bus> bus = new Implementor<Bus>();
Console.WriteLine(bus);
bus.Display(aBus);

//vehicle = bus; // Error
// Contravarince allows the following
// but you'll receive a compile-time error 
// if you do not make the interface contravariant using 'in' 
bus = vehicle; // OK
Console.WriteLine(bus);
bus.Display(aBus);


interface IContraInterface<in A>
//interface IContraInterface<A>
{
   void Display(A obj);
}
//interface IContraInterface<A> { }
class Implementor<A> : IContraInterface<A>
{
    public void Display(A obj)
    {
        Console.WriteLine(obj);
    }
    public override string ToString()
    {
        Type listType = typeof(A);
        return "Implementor[" + listType + "]";
    }
}


class Vehicle
{
    public override string ToString()
    {
        return "One vehicle";
    }
}
class Bus : Vehicle
{
    public override string ToString()
    {
        return "One bus";
    }
}
