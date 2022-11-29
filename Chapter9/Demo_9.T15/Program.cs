Console.WriteLine("---9.T15---");
Console.WriteLine(new Sample()._flag2);
Console.WriteLine(new Sample()._flag2);
class Sample
{
    // The following line causes the error CS0133
    //public const int _flag1 = new Random().Next();
    public readonly int _flag2 = new Random().Next(500);
}

