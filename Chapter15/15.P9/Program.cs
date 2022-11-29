using Container1;
Sample sample = new();

sample.AboutMe();
Console.WriteLine($"12+7={sample.Add(12, 7)}");

namespace Container1
{
    public partial class Sample
    {
        public void AboutMe()
        {
            Console.WriteLine("Experimenting with the partial class 'Sample'.");
        }
    }
    public partial class Sample
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}


