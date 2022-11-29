Console.WriteLine("---10.T8 and 10.T9---");

// To demonstrate the Func delegate
Func<double, double, int> funcDel = Sample.ApproximateTotal;
Console.WriteLine($"Approximately, the sum of {10.5} and {20.7} is: {funcDel(10.5, 20.7)}");

// To demonstrate the Action delegate
Action<int, int> actionDel = Sample.DisplaySum;
actionDel(10, 20);

// To demonstrate 10.T9
// Func<int, int, void> funcDel2 = Sample.DisplaySum; // ERROR CS1547

class Sample
{

    // For Demo of Func(10.T8)
    public static int ApproximateTotal(double a, double b)
    {
        // Some code, if any
        double temp = a + b;
        return (int)temp;
    }

    // For Demo of Action(10.T8)
    public static void DisplaySum(int a, int b)
    {
        Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
        // Some other code, if any
    }

}


