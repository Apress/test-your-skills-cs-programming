Console.WriteLine("---9.P20---");
//Console.WriteLine(new Sample()._flag);// ERROR CS0176
//Console.WriteLine(Sample._flag);//OK, output:1
class Sample
{
    internal const int _flag = 1;

    //internal static const int _flag = 1; // ERROR CS0504

}



