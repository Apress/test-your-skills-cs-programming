Console.WriteLine("---5.P23---");
Console.WriteLine("Experimenting covariance.");
Parent parent = new Parent();
Console.WriteLine($"The flag value in the parent class is: {parent.GetFlag(5).Flag}");
parent = new Child();
Console.WriteLine($"The flag value in the child class is: {parent.GetFlag(5).Flag}");
public class Parent
{
    public int Flag;
    public virtual Parent GetFlag(int flag)
    {
        this.Flag = flag;
        return this;
    }
}
public class Child : Parent
{
    public override Child GetFlag(int flag) // OK 
    {
        this.Flag = flag * 2;
        return this;
    }
}
