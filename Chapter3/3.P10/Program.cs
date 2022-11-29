Console.WriteLine("\n---3.P10---");
class Test
{
    //int flag = 2; //Error :CS0120
    //static readonly int flag = 2; //Error :CS0133
    const int flag = 2; // Ok
    enum Codes
    {
        Code1 = 1,
        // ERROR :CS0120 if you use: int flag = 2;
        // ERROR :CS0133 if you use:  static readonly int flag = 2;
        Code2 = flag,
        Code3 = 3
    };
}