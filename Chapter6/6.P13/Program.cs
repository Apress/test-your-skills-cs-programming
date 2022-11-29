Console.WriteLine("---6.P13---");
Console.WriteLine("Case study-6.P13");
interface IAnimal
{
    void Sound();
    void Run();
}
//class Tiger : IAnimal // ERROR CS0535 at present
abstract class Tiger : IAnimal // OK now
{
    public abstract void Run(); 
    public void Sound() => Console.WriteLine("Tigers roar.");
}


