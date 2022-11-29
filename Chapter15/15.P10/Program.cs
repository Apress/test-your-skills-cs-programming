//Console.WriteLine("---15.P10---");
using Container1;
using Container2;

//Sample sample = new();
//sample.AboutMe();
//Console.WriteLine($"12+7={sample.Add(12, 7)}");

namespace Container1
{
    public partial class Sample
    {
        public void AboutMe()
        {
            Console.WriteLine("Experimenting with the partial class 'Sample'.");
        }
    }

}
namespace Container2
{
    public partial class Sample
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
