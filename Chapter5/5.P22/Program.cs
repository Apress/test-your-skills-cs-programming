Console.WriteLine("---5.P22---");
Console.WriteLine("Understanding the new Keyword in C#.");

// Case study-(5.P22)
Parent parent = new Parent();
Console.WriteLine(parent.GetNumber(5));
Console.WriteLine(parent.GetNumber(5, 7));

Console.WriteLine("-----");
Child child = new Child();
Console.WriteLine(child.GetNumber(5));
Console.WriteLine(child.GetNumber(5, 7));

//Console.WriteLine("-----");
// We'll discuss the following code in Chapter 6
//parent = new Child();
//Console.WriteLine(parent.GetNumber(5));
//Console.WriteLine(parent.GetNumber(5, 7));

class Parent
{
    internal virtual int GetNumber(int i) => i;
    public virtual int GetNumber(int i, int j) => i + j;
}
class Child : Parent
{
    internal override int GetNumber(int i) => i + 2;

    internal new int GetNumber(int i, int j) => i + j + 15;

}




