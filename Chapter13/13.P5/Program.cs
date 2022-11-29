Console.WriteLine("---13.P5---");
IVehicle<string> vehicle = new Car<string>();
string color = vehicle.GetColor("green");
vehicle.Describe();
Console.WriteLine($"Its color is {color}.");

interface IVehicle<T>
{
    T GetColor(T color);
    // A non-generic method
    public void Describe();

}
//Implementing the interface
class Car<T> : IVehicle<T>
{
    // Implementing interface method
    public T GetColor(T color) => color;
    public void Describe() => Console.WriteLine("This is a car.");

}
