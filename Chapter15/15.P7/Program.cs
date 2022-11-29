Console.WriteLine("---15.P7---");
Sample sample1 = new(5);
Console.WriteLine($"Inside sample1, {sample1}");

class Sample
{
    int _flag;
    public Sample(int flag)
    {
        _flag = flag;
    }

    // ERROR CS0448
    //public static void operator ++(Sample sample)
    //{
    //    sample._flag++;
    //    //  return sample;
    //}
  
    public override string ToString()
    {
        return $"current value is {_flag}";
    }
}
