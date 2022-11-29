using Extensions;
Console.WriteLine("---9.P5---");
int flag1 = 15;
int flag2 = flag1.IncrementByFive();
Console.WriteLine($"flag2 is {flag2}");

namespace Extensions
{
    public static class IntExtension
    {
        public static int IncrementByFive(this int i)
        {
            return i + 5;
        }
    }
}
