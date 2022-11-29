Console.WriteLine("---5.P1---");
// Console.WriteLine("Testing the calling sequence of constructors.");
GrandChild grandChild = new GrandChild();
class Parent
{
    //public Parent()
    //{
    //    Console.WriteLine("The parent class constructor is called.");
    //}
    public Parent() => Console.WriteLine("The parent class constructor is called.");
}
class Child : Parent
{
    //public Child()
    //{
    //    Console.WriteLine("The child class constructor is called.");
    //}
    public Child() => Console.WriteLine("The child class constructor is called.");

}
class GrandChild : Child
{
    //public GrandChild()
    //{
    //    Console.WriteLine("The grandchild class constructor is called.");
    //}
    public GrandChild() => Console.WriteLine("The grandchild class constructor is called.");
}






