Console.WriteLine("---6.P22---");
#region Incorrect code
/*
Console.WriteLine("Experimenting a default interface method.");
Car car = new();
//car.Describe(); // ERROR CS1061

interface IVehicle
{
    internal void Describe() =>
       Console.WriteLine("The XYZ company makes this car.");
}
class Car : IVehicle
{

}
*/
#endregion

#region Correct code

Car car = new();
car.Describe(); // OK now

// Calling the explicit interface implementation
((IVehicle)car).Describe();

interface IVehicle
{
    internal void Describe() =>
        Console.WriteLine("The XYZ company makes this car.");

}
class Car : IVehicle
{
    internal void Describe()
    {
        Console.WriteLine("Overriding the default interface method.");
        // Some other code-if any
    }
    void IVehicle.Describe()
    {
        Console.WriteLine("Explicitly overriding the default interface method.");
        // Some other code-if any
    }

}

#endregion

