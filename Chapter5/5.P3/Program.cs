Console.WriteLine("---5.P3---");
Child child = new Child(1, 2);
child.Display();
class Parent
{
    protected int a;
    public Parent() { }
    public Parent(int a)
    {
        this.a = a;
    }
}
class Child : Parent
{
    internal int b;
    public Child(int a, int b) : base(a)
    {
        this.b = b;
    }
    public void Display()
    {
        Console.WriteLine("Initialized values are:");
        Console.WriteLine($"a={a}");
        Console.WriteLine($"b={b}");
    }
}


