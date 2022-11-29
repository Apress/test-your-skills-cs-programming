Console.WriteLine("---4.P1---");
Sample sample = new();
Console.WriteLine($"sample.i={sample.i}");
//Console.WriteLine($"sample.f={sample.f.ToString("0.00##")}");
Console.WriteLine($"sample.d={sample.d}");
class Sample
{
    internal int i = 5;
    internal double d = default;
    internal Sample()
    {
        Console.WriteLine($"Current value of i is: {i}");
        Console.WriteLine($"Current value of d is: {d}");
        // Changing the values
        i += 2;
        d++;

    }
}

