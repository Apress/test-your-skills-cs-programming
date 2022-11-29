Console.WriteLine("---9.P13---");
double i = 60.5;
object iBoxed = i;
double? jNullable = 40.2;
if (iBoxed is double a && jNullable is double b)
{
    Console.WriteLine($"Result is {a + b}");  // 100.7
}
