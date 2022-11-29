Console.WriteLine("---6.P4---");
Home home = new CompleteHome();
home.ShowStatus();
abstract class Home
{
    public abstract void ShowStatus();
}
class CompleteHome : Home
{
    public override void ShowStatus() =>
     Console.WriteLine("The home construction is finished.");
}

