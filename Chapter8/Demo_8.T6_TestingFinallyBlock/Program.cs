using System.Net;

Console.WriteLine("***Case study on the exception handling.***");
int a = 10, b = 0;
try
{
    Console.WriteLine($"Inside try..");
    return;

    int c = a / b;
    Console.WriteLine($"The a=10,b=0.So,a/b is :{c}");

}
//catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout)
//{
//    Console.WriteLine($"Encountered: {ex.Message}");
//}
catch (Exception ex)
{
    Console.WriteLine($"Encountered: {ex.Message}");
}
finally
{
    Console.WriteLine("Inside the finally block: you cannot skip me!");
    //return;//error CS0157
    //throw new Exception("Exceptions in finally");
    //Console.WriteLine("End of the the finally block."); // Unreachable code
}



