Console.WriteLine("---12.P15---");
int a = 99;
Sample.Increment(ref a);
class Sample
{
    public delegate int Mydel(int x);
    public static void Increment(ref int a)
    {

        // Using anonymous method(C# 2.0 onwards)
        Mydel del = delegate (int x)
        {
            //Following segment will NOT work
            //x = a;//ERROR CS1628
            return x + 1;

        };
        Console.WriteLine(del(a));
    }
}


