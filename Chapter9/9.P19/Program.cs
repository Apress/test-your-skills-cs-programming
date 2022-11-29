Console.WriteLine("---9.P19---");
new Sample().Display();
class Sample
{
    private const int _flag = 1;
    public Sample()
    {
        //_flag = 25; // ERROR CS0131
    }
    public void Display()
    {
        Console.WriteLine($"Flag is {_flag}");
    }
}

