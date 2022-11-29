Console.WriteLine("---8.P5---");
int a = 100, b = 0;
try
{
    Console.WriteLine($"The result of a/b is :{a / b}");
}
catch
{
    Console.WriteLine("Caught a non-CLS exceptions.");
}
// Will raise compile-time error: CS1017
//catch (Exception ex)
//{
//    Console.WriteLine($"The exception caught: {ex.Message}");
//}

