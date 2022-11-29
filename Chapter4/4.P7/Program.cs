Console.WriteLine("---4.P7---"); 
Sample.NestedSample nested = new();
Console.WriteLine($"Flag2={nested.Flag2}");

class Sample
{
    public int Flag1;
    public Sample()
    {
        Flag1 = 1;
        Console.WriteLine("Sample is initialized.");
    }
    public class NestedSample
    {
        public int Flag2;
        public NestedSample()
        {
            Flag2 = 2;
            Console.WriteLine("NestedSample is initialized.");
        }
    }
}
