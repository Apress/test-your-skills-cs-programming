Console.WriteLine("---5.P2---");
Console.WriteLine("*** Analyzing C#'s field initialization order ***");
//int x = 10;
//int y = x + 2;//ok
B obB = new B();
Console.WriteLine($"x={obB.x}");
//Console.WriteLine($"y={obB.y}");

class A
{
    internal int x = 1;
}
class B : A
{
    //internal int y = x + 2; // ERROR CS0236
}
