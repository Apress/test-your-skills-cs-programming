Console.WriteLine("---15.P8---");
// Some code

class Sample
{
    int _flag;
    public Sample(int flag)
    {
        _flag = flag;
    }

    //// ERROR CS0590
    //public static void operator +(Sample sample1, Sample sample2)
    //{
    //    // return new Sample(sample1._flag + sample2._flag);
    //}
    public override string ToString()
    {
        return $"current value is {_flag}";
    }
}

