Console.WriteLine("---3.P11 and 3.P12---");
// For 3.P11
Console.WriteLine($"Type0= {(int)Sample.ErrorTypes.NetworkError}");
Console.WriteLine($"Type2= {(Sample.ErrorTypes)2}");

// For 3.P12
Sample sample = new Sample();
//Console.WriteLine($"Type0= {(int)sample.ErrorTypes.NetworkError}"); // Error CS0572

//Sample.Nested ob; // OK
//sample.Nested ob2;//ERROR CS0118
class Sample
{
    public enum ErrorTypes
    {
        NetworkError,
        CodeError,
        DeviceError,
    }
  //  public class Nested { }

}
