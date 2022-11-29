Console.WriteLine("---15.P4---");
Test.Show();

interface ITest
{
    static abstract void Show(); // ERROR CS8703 in C#10.0

}
class Test : ITest
{
    public static void Show()
    {
        Console.WriteLine("Implementing a static abstract method in an interface.");
    }

}

