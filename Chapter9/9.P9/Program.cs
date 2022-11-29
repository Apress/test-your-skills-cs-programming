Console.WriteLine("---9.P9---");
Console.WriteLine("Passing a value type by value.");
int flag = 50;
Sample.Change(flag);
Console.WriteLine($"The final value is {flag}"); // 50
class Sample
{
   internal static void Change(int x)
    {
        x *= 2;
        Console.WriteLine($"Inside Change(), the value is {x}"); // 100
    }   
}
