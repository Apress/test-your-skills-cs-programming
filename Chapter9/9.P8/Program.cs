//Console.WriteLine("---9.P8---");
using Extensions;
Sample sample = new();
sample.Display();

public class Sample
{    
    public void Display()
    {
        Console.WriteLine("The instance method is called.");
    }
}

namespace Extensions
{
    public static class SampleExtension
    {
        public static void Display(this Sample s)
        {
            Console.WriteLine("The extension method is called.");
        }
    }
}
