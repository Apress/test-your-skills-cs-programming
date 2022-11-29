Console.WriteLine("---6.P12---");
Console.WriteLine("Interface case studies.");
IAnimal animal = new Tiger();
animal.Sound();
animal = new Dog();
animal.Sound();

interface IAnimal
{
    void Sound();
}
class Tiger : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Tigers roar.");
    }
}
class Dog : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Dogs bark.");
    }
}


