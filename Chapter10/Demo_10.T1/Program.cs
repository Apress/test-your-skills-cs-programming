Console.WriteLine("---10.T1---");
int a = 25, b = 75;
static int Sum(int a, int b) {
    return a + b; 
}
// Case-1
Console.WriteLine("Called the Sum method without using a delegate.");
Console.WriteLine($"a+b={Sum(a, b)}");

// Case-2
Program_10_T1.Calculate del = new Program_10_T1.Calculate(Sum);
// Program_10_T1.Calculate del = new (Sum);// Also OK
// Also OK. I'll use the following syntax next time onwards.
// Program_10_T1.Calculate del = Sum; 


Console.WriteLine("Called the Sum method using a delegate.");
Console.WriteLine($"a+b={del(a, b)}");

// del(a,b) is shorthand for del.Invoke(a,b)
Console.WriteLine("Called the Sum method using a delegate. Used the Invoke method directly.");
Console.WriteLine($"a+b={del.Invoke(a, b)}"); 

namespace Program_10_T1
{
    public delegate int Calculate(int x, int y);
}
