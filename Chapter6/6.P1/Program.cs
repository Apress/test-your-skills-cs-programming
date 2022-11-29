Console.WriteLine("---6.P1---");
Console.WriteLine("Understanding the new Keyword in C#.");
Parent parent = new Parent();
Console.WriteLine(parent.GetNumber(5));
Console.WriteLine(parent.GetNumber(5, 7));

Console.WriteLine("-----.");
parent = new Child();
Console.WriteLine(parent.GetNumber(5));
Console.WriteLine(parent.GetNumber(5, 7));

//Child child = new Child();
//Console.WriteLine(child.GetNumber(5, 7)); // Invokes the child class method


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


