Console.WriteLine("---6.P20---");
Console.WriteLine("Experimenting with implicit and explicit interface implementations.");
XyzCar car = new();
car.Describe();

((IVehicle)car).Describe();
((ICompany)car).Describe();

// Case study-6.P20
interface IVehicle
{
    void Describe();
}
interface ICompany
{
    void Describe();
}

class XyzCar : IVehicle, ICompany
{
    public void Describe() =>
        Console.WriteLine("This is a car from XYZ company.");

    void IVehicle.Describe() =>
        Console.WriteLine("Implementing  IVehicle.Describe().");


    void ICompany.Describe() =>
        Console.WriteLine("Implementing ICompany.Describe().");

}

