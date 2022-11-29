Console.WriteLine("---4.P10---");
Sample sample = new();
sample.AddTwoNumbers(5,10.7);
class Sample
{    
    public void AddTwoNumbers(int num1,double num2)
    {
        var number1 = num1;
        var number2 = num2;
        Console.WriteLine($"Result: { number1 + number2}");
    }

}

