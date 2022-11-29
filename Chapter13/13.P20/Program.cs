Console.WriteLine("---13.P20---");
Sample sample = new();
sample.Display(5);// OK
sample.Display<int>(5);// Also OK
sample.Display(5, 10.7);// OK
sample.Display<int, double>(5, 10.7);// Also OK
class Sample
{
    public void Display<T>(T p1)
    {
        Console.WriteLine("Inside Display(T t1)");
    }
    public void Display<T, U>(T t1, U u2)
    {
        Console.WriteLine("Inside Display(T t1, U u2)");
    }
}



