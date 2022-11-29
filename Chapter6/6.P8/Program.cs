Console.WriteLine("---6.P8---");
Animal monkey = new Monkey("black");
monkey.Run();
monkey.Jump();
abstract class Animal
{
    string? color;
    public Animal(string color)
    {
        Console.WriteLine($"Instantiating an animal with { color} color.");
    }

    public void Run() =>
        Console.WriteLine("It can run.");

    public abstract void Jump();

}
class Monkey : Animal
{
    public Monkey(string color) : base(color) =>
        Console.WriteLine("It becomes a monkey.");

    public override void Jump() =>
        Console.WriteLine("It can jump.");
}


