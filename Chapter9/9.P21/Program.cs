Console.WriteLine("---9.P21---");
new Sample().Display();
class Sample
{
    private static readonly int s_flag = 1;
    public void Display()
    {
        //s_flag = 25; // ERROR CS0198
        Console.WriteLine($"Flag is {s_flag}");
    }
}

