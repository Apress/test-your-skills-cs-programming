using System.Net;

Console.WriteLine("---8.P10---");
Console.WriteLine("***A case study on exception filters.***");
try
{
    int a = 10;
    // Returns a random number between 0(inclusive) and 2(exclusive)
    int b = new Random().Next(0, 2);
    Console.WriteLine($"b={b}");
    int c = b > 0 ? throw new WebException("Timeout error") : throw new WebException("Protocol error");
    Console.WriteLine("Thank you.");
}
catch (Exception ex) when (ex.Message.Contains("Timeout"))
{
    Console.WriteLine($"Caught: " + ex.Message);
}

catch (Exception ex) when (ex.Message.Contains("Protocol"))
{
    Console.WriteLine($"Caught: " + ex.Message);
}

