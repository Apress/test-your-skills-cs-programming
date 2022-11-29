Console.WriteLine("***The case study on the throw statement.***");
try
{
    // Some code before
    throw new IndexOutOfRangeException("Index is out of range.");

}
catch (Exception ex)
{
    Console.WriteLine($"The exception caught: {ex.Message}");  

}

