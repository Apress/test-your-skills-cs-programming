Console.WriteLine("---4.P12---");
//Sample sample = new(); // ERROR CS0122
Sample sample=Sample.GetInstance();
Console.WriteLine($"sample._flag = {sample._flag}");

class Sample
{
    internal double _flag;
    private Sample()
    {
        _flag = 5.75;

    }
    public static Sample GetInstance()
    {
        return new Sample();
    }

}
