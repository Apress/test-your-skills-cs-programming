Console.WriteLine("---10.P7---");
Func<int, int, int> del = Program_10_P7.Sample.Sum;
del += Program_10_P7.Sample.Difference;
int finalValue = del(10, 5);
Console.WriteLine($"The final value is {finalValue}");

namespace Program_10_P7
{   
    class Sample
    {
        public static int Sum(int a, int b)
        {
            // Console.WriteLine($"Sum={a + b}");
            return a + b;
        }
        public static int Difference(int a, int b)
        {
            // Console.WriteLine($"Difference={a - b}");
            return a - b;
        }      
    }
}

