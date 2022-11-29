Console.WriteLine("---6.P15---");
IElectronicDevice laptop = new IdeaPad330S();
laptop.ShowConfiguration();
laptop.DisplayStorage();

interface IElectronicDevice
{
    void DisplayStorage();
    void ShowConfiguration();
}
class Laptop
{
    public virtual void ShowConfiguration()
    {
        Console.WriteLine("A laptop must have an operating system and ram.");
    }
}
class IdeaPad330S : Laptop, IElectronicDevice
{
    public override void ShowConfiguration()
    {
        base.ShowConfiguration();
        Console.WriteLine("An Ideapad330S supports Windows OS, 4GB ram, and 1TB HDD storage.");
    }
    public void DisplayStorage() =>
        Console.WriteLine("An Ideapad330S has 1TB HDD storage.");    
}


