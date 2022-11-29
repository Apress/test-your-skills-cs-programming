Console.WriteLine("---10.T13---");
Console.WriteLine("Predicate delegate demonstration.");
Predicate<int> isGreater = Sample.TestGreaterThan50;
Console.WriteLine($"51 is greater than 50? {isGreater(51)}");
Console.WriteLine($"49 is greater than 50? {isGreater(49)}");
class Sample
{
    public static bool TestGreaterThan50(int input)
    {
        return input > 50;
    }
}

