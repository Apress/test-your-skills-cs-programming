// Console.WriteLine("***Case study with a general catch block.***");
//using System.Runtime.CompilerServices;

int a = 100, b = 0;
try
{
    Console.WriteLine($"The result of a/b is :{a / b}");
}
catch (Exception ex)
{
    Console.WriteLine($"The exception caught: {ex.Message}");
}
//catch (RuntimeWrappedException e)
//{
//    // Some code
//}
catch
{
    Console.WriteLine("Caught a non-CLS exceptions.");
}

