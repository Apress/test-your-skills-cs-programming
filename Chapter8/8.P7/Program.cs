Console.WriteLine("---8.P7---"); 
Console.WriteLine("***The case study on the throw keyword.***");
NumberMaker numberMaker = new();
try
{
    Console.WriteLine($"numbers[0]={numberMaker.GetNumber(0)}");
    Console.WriteLine($"numbers[3]={numberMaker.GetNumber(3)}");

}
catch (Exception ex)
{
    Console.WriteLine($"\nThe Main() caught: {ex.Message}");
    Console.WriteLine($"\tStacktrace:{ex.StackTrace}");

}
class NumberMaker
{
    int[] _numbers = { 1, 2, 3 };

    internal int GetNumber(int index)
    {
        try
        {
            if (index < 0 || index >= _numbers.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nThe GetNumber(...) caught: {ex.Message}");
            Console.WriteLine($"\tStacktrace:{ex.StackTrace}");
            throw;            
        }
        return _numbers[index];

    }
}
