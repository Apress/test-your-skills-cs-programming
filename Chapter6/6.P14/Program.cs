Console.WriteLine("---6.P14---");
IAnimal tiger = new BengalTiger();
tiger.Sound();
tiger.Run();
interface IAnimal
{
    void Sound();
    void Run();
}
abstract class Tiger : IAnimal
{
    public abstract void Run();

    public void Sound() => Console.WriteLine("Tigers roar.");

}
class BengalTiger : Tiger
{
    public override void Run() =>
        Console.WriteLine("Bengal tigers run fast.");
}


