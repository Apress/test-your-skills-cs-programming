Console.WriteLine("---9.P17---");

new Sample().Display();

class Sample
{
    private static readonly int s_flag = 1;
    static Sample()
    {
        s_flag = 25;
    }
    public void Display()
    {
        Console.WriteLine($"Flag is {s_flag}");
    }
}
