Console.WriteLine("---3.T1---");

Console.WriteLine($"Type0 is: {(ErrorTypes)0}");// NetworkError
Console.WriteLine($"Type1 is: {(ErrorTypes)1}");// CodeError
Console.WriteLine($"Type2 is: {(ErrorTypes)2}");// DeviceError

public enum ErrorTypes
{
    NetworkError,
    CodeError,
    DeviceError,
}




