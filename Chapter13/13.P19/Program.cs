Console.WriteLine("---13.P19---");
Sample<int, double> sample1 = new();
sample1.Display(5, 10.5); // Ok

Sample<int, int> sample2 = new();
//sample2.Display(5, 15);// ERROR CS0121: Ambiguous call

//Sample<string, double> sample3 = new();
//sample3.Display("abc", 10.5); // OK

class Sample<T, U>
{
    public void Display(T p1, U p2)
    {
        Console.WriteLine("Inside Display(T p1, U p2)");
    }
    public void Display(U p1, T p2)
    {
        Console.WriteLine("Inside Display(U p1, T p2)");
    }
}

