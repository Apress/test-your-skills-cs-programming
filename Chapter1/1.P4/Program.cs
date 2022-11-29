Console.WriteLine("\n---1.P3---");
Console.WriteLine($"The max value of an int is:{int.MaxValue}");
Console.WriteLine($"The min value of an int is:{int.MinValue}");
int flag = int.MaxValue;
Console.WriteLine($"Currently, the flag is: {flag}");
unchecked
//checked
{
    flag++;
    Console.WriteLine($"Post increment,the flag is: {flag}");
}
Console.WriteLine("\n---End of 1.P3---");



