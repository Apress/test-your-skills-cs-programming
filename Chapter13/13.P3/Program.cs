Console.WriteLine("---13.P3---");

Sample.PrintDefault<int>(); // 0
Sample.PrintDefault<int?>(); // null
Sample.PrintDefault<sbyte>(); // 0
Sample.PrintDefault<double>();// 0
Sample.PrintDefault<bool>(); // False
Sample.PrintDefault<string>(); // null
Sample.PrintDefault<object>(); // null
Sample.PrintDefault<System.Numerics.Complex>(); // (0,0)
Sample.PrintDefault<List<int>>(); // null
Sample.PrintDefault<List<string>>(); // null
class Sample
{
    internal static void PrintDefault<T>()
    {
        //T? defaultValue = default;
        //Same as:
        T? defaultValue = default(T);
        string? printMe = (defaultValue == null) ? "null" : defaultValue.ToString();
        Console.WriteLine($"The default value of {typeof(T)} is {printMe}.");
    }
}


