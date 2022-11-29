Console.WriteLine("---12.P12---");
Action del = new Test().SampleMethod;
del();

class Test
{
    internal unsafe void SampleMethod()
    {
        int a = 10;
        int* p = &a;
        Console.WriteLine($"a={a}");
        Console.WriteLine($"*p={*p}");
    }
}

