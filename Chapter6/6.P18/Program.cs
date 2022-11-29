Console.WriteLine("---6.P18---");
IVehicle car = new Car();
car.Describe();

interface IVehicle
{
    void Describe();
}

class Car : IVehicle
{
    void IVehicle.Describe()
    {
        Console.WriteLine("This is a car.");
    }
}


