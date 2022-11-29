Console.WriteLine("---8.P9---");
Console.WriteLine("***The case study on the throw expression.***");
try
{
    int a = 10;
    // Returns a random number between 0(inclusive) and 2(exclusive)
    int b = new Random().Next(0, 2);
    Console.WriteLine($"b={b}");
    int c = b > 0 ? (a / b) : throw new DivideByZeroException("b becomes 0");
    Console.WriteLine("Thank you.");
}
catch (Exception ex)
{
    Console.WriteLine($"Caught: " + ex.Message);
}
