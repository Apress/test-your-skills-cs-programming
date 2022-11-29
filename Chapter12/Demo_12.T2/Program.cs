Console.WriteLine("---12.T2---");
Console.WriteLine(" Using a normal method call.");
int a = 10, b = 5;
Console.WriteLine(" Invoking the Sum() method without using a delegate.");
Console.WriteLine($" The sum of {a} and {b} is {Sample.Sum(a, b)}");

// Using an in-built delegate
Func<int, int, int> del1 = Sample.Sum;
Console.WriteLine("\n Using delegate now.");
Console.WriteLine(" Invoking the Sum() method using a delegate.");
Console.WriteLine($" The sum of {a} and {b} is {del1(a, b)}");

// Using Anonymous method (C# 2.0 onwards)
Console.WriteLine("\n Using an anonymous method now.");
Sample.Mydel del2 = delegate (int x, int y) { return x + y; };
Console.WriteLine(" Invoking the Sum() method using an anonymous method.");
Console.WriteLine($" The sum of {a} and {b} is {del2(a, b)}");


// Using a lambda expression(C# 3.0 onwards)
Console.WriteLine("\n Using lambda expression now.");
Func<int, int, int> del3 = (x, y) => x + y;
Console.WriteLine($" The sum of {a} and {b} is {del3(a, b)}");


class Sample
{
    public delegate int Mydel(int x, int y);
    public static int Sum(int x, int y)
    {
        return x + y;
    }
}
// 12.T3
class Sample2
{
    bool IsPositive1(int x) { return x > 0; } // Plain method
    bool IsPositive2(int x) => x > 0; // Using lambda exp

}
