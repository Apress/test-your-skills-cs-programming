//Console.WriteLine("---9.P11---");
using Container1;
Sample sample = new();
sample.SayHello();
namespace Container1
{
    public partial class Sample
    {
        internal partial void SayHello();
    }
    public partial class Sample
    {
        internal partial void SayHello()
        {
            Console.WriteLine("Hello, reader!");
        }
    }
}

