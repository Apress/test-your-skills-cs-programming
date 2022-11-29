Console.WriteLine("---9.P10---");
int flag = 50;
//int flag; // Must be assigned if you use 'ref'
Sample.Change(ref flag);
Console.WriteLine($"The final value is {flag}");
class Sample
{
    internal static void Change(ref int x)
    {
        x *= 2;
        Console.WriteLine($"Inside Change(), the value is {x}");
    }
}

