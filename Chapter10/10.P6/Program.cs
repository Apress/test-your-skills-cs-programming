Console.WriteLine("---10.P6---");

Func<double,double,int> del = Sample.Sum;
Console.WriteLine($"Approximately, the sum of {10.5} and {20.7} is: {del(10.5, 20.7)}");

class Sample
{
    public static int Sum(double a, double b)
    {
        Console.WriteLine("The Sum method of the Sample class is invoked.");
        double temp = a + b;
        return (int)temp;
    }   

}

