Console.WriteLine("---8.T10---");
Console.WriteLine("***Custom Exception Example***");
int a = 10, b = 2, result;
try
{
    b--;
    if (b == 1)
    {
        throw new SmallDivisorException($"The divisor becomes {b}");
        //throw new SmallDivisorException();        
    }
    result = a / b;
}
catch (SmallDivisorException ex)
{
    Console.WriteLine($"Caught the custom exception: {ex.Message}");
}
finally
{
    Console.WriteLine("\nThank you!");
}


class SmallDivisorException : Exception
{
    public SmallDivisorException() { }
    public SmallDivisorException(string msg) : base(msg) { }
    public SmallDivisorException(string msg, Exception inner) : base(msg, inner)
    { }
}




