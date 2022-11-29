Console.WriteLine("---1.P9---");
Console.WriteLine("---Use of an if-else chain.---");
int input = 7;
if (input % 2 == 0)
{
    Console.WriteLine($"{input} is an even number.");
}
else
{
    Console.WriteLine($"{input} is an odd number.");
}

Console.WriteLine("\n---End of 1.P9---");



Console.WriteLine("\n---1.P10---");

CheckNumber(25.5);
CheckNumber(125.5);
CheckNumber(10.000);

void CheckNumber(double number)
{
    switch (number)
    {
        case double.NaN:
            Console.WriteLine($"{number} is not a number.");
            break;
        case < 10.0:
            Console.WriteLine($"{number} is less than 10.0");
            break;
        default:
            Console.WriteLine($"{number} is equal to 10.0");
            break;
        //case >= 10.0:// Warning
        case > 10.0:
            Console.WriteLine($"{number} is greater than or equal to 10.0");
            break;
    }
}

Console.WriteLine("\n---End of 1.P10---");

Console.WriteLine("\n---1.P11---");

CheckNumbers(5, 23);
CheckNumbers(12, 5 + 7);
CheckNumbers(-7, 239);

void CheckNumbers(int num1, int num2)
{
    switch (num1, num2)
    {

        case ( > 0, > 0) when num1 != num2:
            Console.WriteLine($"{num1} and {num2} are unequal positive numbers.");
            break;
        case ( > 0, > 0):
            Console.WriteLine($"{num1} and {num2} are the same positive numbers.");
            break;
        default:
            Console.WriteLine($"Atleast one of {num1} or {num2} is 0 or negative.");
            break;
    }
}

Console.WriteLine("\n---End of 1.P11---");

Console.WriteLine("\n---1.P12---");

EvaluateNumber(5);
EvaluateNumber(125);
EvaluateNumber(-2);

void EvaluateNumber(int num)
{
    switch (num)
    {
        case > 100:
            Console.WriteLine($"{num} is greater than 100.");
            break;
        case > 5:
            Console.WriteLine($"{num} is greater than 5.");
            // break; // without break, you'll see: error CS 0163
            break;
        default:
            Console.WriteLine($"{num} is less than 5.");
            break;
    }
}

Console.WriteLine("\n---End of 1.P12---");

Console.WriteLine("\n---1.P13---");

ShowNumber(5);
ShowNumber(125);
ShowNumber(-2);

void ShowNumber(int num)
{
    switch (num)
    {

        case < 5:
        case < 50: //Console.WriteLine("Some statements.");    
        case < 100:
            Console.WriteLine($"{num} is less than 100.");
            break;
        default:
            Console.WriteLine($"{num} is greater than or equal to 100.");
            break;
    }
}

Console.WriteLine("\n---End of 1.P13---");





