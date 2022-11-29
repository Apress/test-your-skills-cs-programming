//Console.WriteLine("---9.P7---");
using Extensions;
Sample sample = new();
sample.DisplayNumber();
sample.DisplayString();

public class Sample
{
    int _flag = 10;
    public void DisplayNumber()
    {
        Console.WriteLine(_flag);
    }
}

namespace Extensions
{
    public static class SampleExtension
    {
        public static void DisplayString(this Sample s)
        {
            Console.WriteLine(s.ToString());
            //Console.WriteLine(s._flag);// ERROR CS0122
        }

    }
}
