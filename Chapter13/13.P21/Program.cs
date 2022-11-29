Console.WriteLine("---13.P21---");
Parent parent = new();
parent.Display(5); // OK

parent = new Derived();
parent.Display("5"); // OK
parent.Display("abc"); // OK


class Parent
{
    public virtual void Display<T>(T p1)
    {
        Console.WriteLine("Parent's Display");
    }
}
class Derived : Parent
{
    public override void Display<T>(T p1)
    {
        Console.WriteLine("Derived's Display");
    }
}

