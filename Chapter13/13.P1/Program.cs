Console.WriteLine("---13.P1---");
Price<int> intOb = new();
Console.WriteLine($"The int version shows {intOb.Display(123)}");
Price<string> stringOb = new();
Console.WriteLine($"The string version shows {stringOb.Display("hello")}");
Price<double> doubleOb = new();
Console.WriteLine($"The double version shows {doubleOb.Display(456.78)}");
class Price<T>
{
    //public T Display(T value)
    //{
    //    return value;
    //}
    public T Display(T value) => value;    
}
