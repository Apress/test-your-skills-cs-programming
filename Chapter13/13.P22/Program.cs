Console.WriteLine("---13.P22---");
Console.WriteLine("***Testing static in the context of generic programming.***");
Sample<int> intOb = new();
Console.WriteLine("\nUsing intOb now.");
intOb.Increment();// 1
intOb.Increment();// 2
intOb.Increment();// 3

Console.WriteLine("\nUsing strOb now.");
Sample<string> strOb = new();
strOb.Increment();// 1
strOb.Increment();// 2

Sample<int> intOb2 = new();
Console.WriteLine("\nUsing intOb2 now.");
intOb2.Increment();// 4
intOb2.Increment();// 5 

Sample<string> strOb2 = new();
Console.WriteLine("\nUsing strOb2 now.");
strOb2.Increment();// 3
strOb2.Increment();// 4
class Sample<T>
{
    public static int count;
    public void Increment() => Console.WriteLine($"Incremented value is {++count}");

}
