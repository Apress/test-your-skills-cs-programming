Console.WriteLine("---4.P3---"); 
Sample sample = new();
Console.WriteLine($"sample._flag={sample._flag}");
Console.WriteLine($"sample._number={sample._number}");

class Sample
{
    internal int _flag;
    internal double _number;
    internal Sample() : this(5) { }
    internal Sample(int i)
    {
        this._flag = i;
        this._number = _flag * 2;
    }
}
