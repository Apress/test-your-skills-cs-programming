Console.WriteLine("---9.P11---");
int flag;
Sample.Change(out flag);
Console.WriteLine($"The final value is {flag}");
class Sample
{
    internal static void Change(out int x)
    {
        x = 100;
        Console.WriteLine($"Inside Change(), the value is {x}");       
    }
}
