Console.WriteLine("***Case study on exception handling.***");
int a = 10, b = 0;
try
{
    int c = a / b;
    Console.WriteLine($"The a=10,b=0.So,a/b is :{c}");
}
catch (Exception ex)
{
    Console.WriteLine($"Encountered: {ex.Message}");
}
finally
{
    Console.WriteLine("Inside the finally block: you cannot skip me!");
}

