Console.WriteLine("---10.P2---");
CustomDelegate.MyDel del = Sample.Sum;
//Console.WriteLine($"The sum of {10} and {20} is: {del(10)}"); // ERROR CS7036
Console.WriteLine($"The sum of {10} and {20} is: {del(10,20)}"); // OK
namespace CustomDelegate
{
    public delegate int MyDel(int x, int y);
}

class Sample
{
    public static int Sum(int a, int b)
    {
        Console.WriteLine("The Sum method of the Sample class is invoked.");
        return a + b;
    }
}

