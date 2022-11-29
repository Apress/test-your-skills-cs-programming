Console.WriteLine("---4.P9---"); 
Sample sample = new();
class Sample
{
    internal int _flag1,_flag2;
    internal Sample(int i = 5)
    {
        this._flag1 = i;
        this._flag2 = 0;
        Increment();
    }   
    public void Increment()
    {
        _flag1++;
        _flag2++;
        Console.WriteLine($"_flag1={_flag1}");
        Console.WriteLine($"_flag2={_flag2}");
    }

}