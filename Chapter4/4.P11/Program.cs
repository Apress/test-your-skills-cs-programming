Console.WriteLine("---4.P11---");

Sample sample = new();
sample.AddTwoNumbers();
//var _flag3 = 1; // OK
class Sample
{
    int _flag1=5;
    int _flag2 = 7;
    //var _flag2 = 7; //ERROR 0825

    public void AddTwoNumbers()
    {
        var number1 = _flag1;
        var number2 = _flag2;
        Console.WriteLine(number1 + number2);
    }

}

