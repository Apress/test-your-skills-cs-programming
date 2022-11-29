Console.WriteLine("---3.P13---");

Console.WriteLine(ErrorTypes.NetworkError & ErrorTypes.CodeError);
//Console.WriteLine((int)(ErrorTypes.NetworkError & ErrorTypes.CodeError));//0
Console.WriteLine(ErrorTypes.DeviceError | ErrorTypes.CodeError | ErrorTypes.NetworkError);// NetworkError,CodeError,DeviceError

//Console.WriteLine((int)(ErrorTypes.DeviceError | ErrorTypes.CodeError|ErrorTypes.NetworkError));// 4|2|1=7
//Console.WriteLine(ErrorTypes.NetworkError | ErrorTypes.CodeError); //NetworkError,CodeError (1|2=3)
//Console.WriteLine(ErrorTypes.DeviceError | ErrorTypes.NoError); //DeviceError (4|0=4)

//Console.WriteLine("-----------------");
//Console.WriteLine($"1 & 4 ={1 & 4}");// 0
//Console.WriteLine($"1 | 2 ={1|2}");// 3
//Console.WriteLine($"1 & 2 ={1 & 2}");// 0
//Console.WriteLine($"3 | 4 ={3 | 4}");// 7
//Console.WriteLine($"2 & 4 ={2 & 4}");// 0
//Console.WriteLine($"4|2|1 ={4|2|1}");// 7

[Flags]
public enum ErrorTypes
{
    NoError = 0,
    NetworkError = 1,
    CodeError = 2,
    DeviceError = 4   
}

