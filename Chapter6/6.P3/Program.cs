Console.WriteLine("---6.P3---");
Vehicle vehicle = new Bus();
vehicle.ShowCommonFeature();
class Vehicle
{
    public virtual void ShowCommonFeature()
    {
        Console.WriteLine("The basic features are added.");
    }
}
class Bus : Vehicle
{
    public override void ShowCommonFeature()
    {
        base.ShowCommonFeature();
        Console.WriteLine("The bus-specific features are added.");
    }
}


