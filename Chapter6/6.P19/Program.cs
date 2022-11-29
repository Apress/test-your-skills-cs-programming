Console.WriteLine("---6.P19---");
XyzCar car = new();
car.Describe();

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
}


