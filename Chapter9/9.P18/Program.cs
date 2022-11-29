Console.WriteLine("---9.P18---");
new Sample().Display();
class Sample
{
    private static readonly int s_flag = 1;
    public Sample()
    {
        //s_flag = 25;// ERROR CS0198
    }
    public void Display()
    {
        Console.WriteLine($"Flag is {s_flag}");
    }
}


