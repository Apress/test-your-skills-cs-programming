Console.WriteLine("---12.P2---");
Test test = new();
Console.WriteLine($"The sum of 5 and 10 is {test.CalculateSum1(5, 10)}");
Console.WriteLine($"The sum of 25 and 100 is {test.CalculateSum2(25, 100)}");
class Test
{
    public int CalculateSum1(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    // Expression-bodied method is not available in C#5.
    // C#6.0 onwards,you can use same expression syntax to  
    // define a non-lambda method within a class
    // It is ok for single expression, i.e. for 
    // expression lambda syntax,but not for statement lambda.

    public int CalculateSum2(int a, int b) => a + b; // OK    
}
