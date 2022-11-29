Console.WriteLine("---5.T6---");
Console.WriteLine("Diamond problem demo.");
class Parent
{
    public void Show()
    {
        Console.WriteLine("Inside the Parent class.");
    }
}
class Child1 : Parent
{
    public void Show()
    {
        Console.WriteLine("Inside the Child-1 class.");
    }
}
class Child2 : Parent
{
    public void Show()
    {
        Console.WriteLine("Inside the Child-2 class.");
    }
}
//class Grandchild : Child1, Child2 // ERROR CS1721
//{
//    public void Show()
//    {
//        Console.WriteLine("Inside the Grandchild class.");
//    }
//}


