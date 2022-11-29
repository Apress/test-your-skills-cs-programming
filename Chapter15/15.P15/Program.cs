Console.WriteLine("---15.P15---");
Container.Parent parent = new Container.Sample();
Console.WriteLine($"The number is: {parent.ShowNumber()}");

namespace Container
{
    public abstract class Parent
    {
        public abstract int ShowNumber();

    }
    public partial class Sample : Parent
    {
        public override partial int ShowNumber();

    }
    public partial class Sample
    {
        public override partial int ShowNumber()
        {
            return 5;
        }
    }
}



