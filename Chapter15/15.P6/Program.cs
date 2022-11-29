Console.WriteLine("---15.P6---");
Sample sample1 = new(5);
Sample sample2 = new(7);
Console.WriteLine($"The sample1 contains {sample1}");
Console.WriteLine($"The sample2 contains {sample2}");
Console.WriteLine("\nTesting the unary operator ++ now.");
sample1++;
Console.WriteLine($"The sample1 contains {sample1}");
Console.WriteLine("\nTesting the binary operator + now.");
Sample sample3 = sample1 + sample2;
Console.WriteLine($"The sample3 contains {sample3}");
class Sample
{
    int _flag;
    public Sample(int flag)
    {
        _flag = flag;
    }

    public static Sample operator ++(Sample sample)
    {
        sample._flag++;
        return sample;
    }
    public static Sample operator +(Sample sample1,
                                   Sample sample2)
    {
        return new Sample(sample1._flag + sample2._flag);
    }
    public override string ToString()
    {
        return $"the value: {_flag}";
    }
}
