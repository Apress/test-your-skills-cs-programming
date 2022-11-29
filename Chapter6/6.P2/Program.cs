Console.WriteLine("---6.P2---"); 
Vehicle vehicle = new Vehicle();
vehicle.ShowCommonFeature();
//vehicle.ShowSpecialFeature(); // ERROR CS1061

class Vehicle
{
    public virtual void ShowCommonFeature()
    {
        Console.WriteLine("Inside Vehicle.ShowCommonFeature");
    }
}
class Bus : Vehicle
{
    public override void ShowCommonFeature()
    {
        Console.WriteLine("Inside Bus.ShowCommonFeature");
    }
    public void ShowSpecialFeature()
    {
        Console.WriteLine("Inside Bus.ShowSpecialFeature");
    }
}
