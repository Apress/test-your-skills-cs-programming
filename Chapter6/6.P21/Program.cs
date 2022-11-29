Console.WriteLine("---6.P21---");
Console.WriteLine("Experimenting with a default interface method.");
IVehicle vehicle = new Car();
vehicle.Describe();
interface IVehicle
{
    internal void Describe() =>
       Console.WriteLine("The XYZ company makes this car.");
}
class Car : IVehicle
{

}


