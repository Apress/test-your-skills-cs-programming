Console.WriteLine("***Case study with multiple catch blocks.***");
int a = 100, b = 0;
try
{
    Console.WriteLine($"The result of a/b is :{a / b}");
}
// Also OK
//catch (DivideByZeroException) { }
catch (DivideByZeroException ex)
{
    Console.WriteLine("Encountered the DivideByZeoException");
}
catch (ArithmeticException ex)
{
    Console.WriteLine("Encountered the ArithmeticException");
}
//// Error CS0160:Exceptions follows the inheritance hierarchy. 
//// So, we need to place catch blocks properly.
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Encountered the DivideByZeoException");
//}

