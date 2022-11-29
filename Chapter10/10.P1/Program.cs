Console.WriteLine("---10.P1---");

int a = 25, b = 35;
Sample sample = new();

CustomDelegates.MyDel1 del1 = Sample.AddFive;
Console.WriteLine($"{a}+5= {del1(a)}");

CustomDelegates.MyDel2 del2 = sample.AddFive;
Console.WriteLine($"{a}+{b}+5= {del2(a, b)}");

namespace CustomDelegates
{
    public delegate int MyDel1(int x);
    public delegate int MyDel2(int x, int y);
}

class Sample
{
    public static int AddFive(int a) { return a + 5; }
    public int AddFive(int a, int b) { return a + b + 5; }
}










