Console.WriteLine("---6.T2---");
Console.WriteLine("Polymorphic code example.");
Animal animal = new Tiger();
animal.Sound();
animal = new Dog();
animal.Sound();
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("An animal can make sounds.");
    }

}
class Tiger : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Tigers roar.");
    }
}
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dogs bark.");
    }
}


