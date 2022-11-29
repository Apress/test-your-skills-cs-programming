Console.WriteLine("---13.P4---");

Sample.PrintDefault<MyClass>(); //null
Sample.PrintDefault <MyStruct> ();
class MyClass
{
    int _flag;
    string _name;
    public override string ToString()
    {
        string temp = $"_flag: {_flag} and _name: {_name}";
        if (_name != null)
            return temp;
        else
            return $"_flag: {_flag} and _name: null";
    }
}



struct MyStruct
{
    int _flag;
    string _name;
    public override string ToString()
    {
        string temp= $"_flag: {_flag} and _name: {_name}";
        if (_name != null)
            return temp;
        else
            return $"_flag: {_flag} and _name: null";
    }
}

class Sample
{
    internal static void PrintDefault<T>()
    {
        T? defaultValue = default;
        //Same as:
        //T defaultValue = default(T);
        string? printMe = (defaultValue == null) ? "null" : defaultValue.ToString();
        Console.WriteLine($"The default value of {typeof(T)} is {printMe}.");
    }
}
