Console.WriteLine("Different case studies of method overriding in C#.");
/*
Console.WriteLine("---5.P14---");
Derived derived = new Derived();
derived.DoNotChangeMe();
derived.ChangeMe();

class Parent
{
    public virtual void ChangeMe()
    {
        Console.WriteLine("Initial version of the ChangeMe().");
    }
    public void DoNotChangeMe()
    {
        Console.WriteLine("Initial version of the DoNotChangeMe().");
    }
}
class Derived : Parent
{
    public override void ChangeMe()
    {
        Console.WriteLine("Updated version of the ChangeMe().");
    }
}
*/


/*
Console.WriteLine("---5.P15---");
class Parent
{
    public void DoNotChangeMe()
    {
        Console.WriteLine("Initial version of the DoNotChangeMe().");
    }
}
class Derived : Parent
{
    //public override void DoNotChangeMe() // Cannot override now
    //{
    //    Console.WriteLine("Updated version of the ChangeMe().");
    //}
}

*/

/*
Console.WriteLine("---5.P16---");
Derived derived = new Derived();
derived.ShowMe();
class Parent
{
    public void ShowMe() =>
        Console.WriteLine("The ShowMe() of Sample.");
}
class Derived : Parent
{
    public void ShowMe() => Console.WriteLine("The ShowMe() of Derived.");

}
*/

/*
Console.WriteLine("---5.P17---");
Derived derived = new Derived();
derived.ShowMe();
class Parent
{
    public virtual void ShowMe() =>
        Console.WriteLine("The ShowMe() of the parent class.");

}
class Derived : Parent
{
    public void ShowMe() =>
        Console.WriteLine("The ShowMe() of the derived class.");
}
*/

/*
Console.WriteLine("---5.P18---");

class Parent
{
    public virtual int GetNumber(int i)
    {
        Console.WriteLine("I am inside the Parent class.");
        return i;
    }
}
class Child : Parent
{
    //public override int GetNumber(int i, int j) // ERROR CS0115
    public override int GetNumber(int i) // OK 
    {
        Console.WriteLine("I am inside the Child class");
        return i + 10;
    }
}
*/

/*
// Case study-(5.19)
Console.WriteLine("---5.P19---");
Parent parent = new Parent();
int value1 = parent.GetNumber(5);
Console.WriteLine($"Value1:{value1}");

Child child = new Child();
int value2 = child.GetNumber(5);
int value3 = child.GetNumber(5, 7);
Console.WriteLine($"Value2:{value2}");
Console.WriteLine($"Value3:{value3}");

class Parent
{
    //public virtual int GetNumber(int i)
    //{
    //    return i;
    //}
    public virtual int GetNumber(int i) => i;   
}
class Child : Parent
{
    //public override int GetNumber(int i)
    //{
    //   return i + 2;
    //}
    //public int GetNumber(int i, int j) //OK 
    //{
    //   return i + j;
    //}
    public override int GetNumber(int i) => i + 2;
    public int GetNumber(int i, int j) => i + j;
   
}

*/
/*
Console.WriteLine("---5.P20---");
class Parent
{
    public virtual int GetNumber(int i) => i;

}

class Child : Parent
{
    //protected override int GetNumber(int i) => i + 2; // ERROR CS0507

}
*/


Console.WriteLine("---5.P21---");
class Parent
{
    internal virtual int GetNumber(int i) => i;

}

class Child : Parent
{
    internal override int GetNumber(int i) => i * 2; // Correct
    //internal override double GetNumber(int i)=> i * 2;
}







