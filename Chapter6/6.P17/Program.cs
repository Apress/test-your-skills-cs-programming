Console.WriteLine("---6.P17---");
SuperCar car = new();
Console.WriteLine("Car details:");
Console.WriteLine($"Has an air conditioner ?{ car.AirConditioner()}");
Console.WriteLine($"Number of wheels:{ car.ShowNumberOfWheels()}");

interface IWheels
{
    int ShowNumberOfWheels();
}
interface IACFacility
{
    bool AirConditioner();
}
class SuperCar : IACFacility, IWheels
{
    public bool AirConditioner() => true;
    public int ShowNumberOfWheels() => 4;

}


