Console.WriteLine("\n---3.P6---");
Console.WriteLine($"The 'BigNumbers' members are {Enum.GetUnderlyingType(typeof(BigNumbers))}");
Console.WriteLine($"The 'SmallNumbers' members are {Enum.GetUnderlyingType(typeof(SmallNumbers))}");
enum BigNumbers
{
    Num1=1001,
    Num2 = 7005,
    Num3 = 3005
};
enum SmallNumbers: short
{
    Num1 = 1,
    Num2 = 7    
};

