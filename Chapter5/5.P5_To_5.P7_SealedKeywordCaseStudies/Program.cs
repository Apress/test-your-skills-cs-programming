Console.WriteLine("Testing the sealed keyword in C#.");
/*
Console.WriteLine("---5.P5---");

Console.WriteLine("Case-Study: 5.P5");
sealed  class Parent
{
    public void ShowClassName()=>
        Console.WriteLine("Inside the Parent class");
   
}
class ChildClass : Parent //Error
{
    //Some code
}
*/


Console.WriteLine("---5.P6---");
Polygon polygon = new Square();

class Polygon
{
    //public Polygon()
    //{
    //    Console.WriteLine("Polygon class constructor.");
    //}
    public Polygon() => Console.WriteLine("Polygon class constructor.");

}
sealed class Square : Polygon
{
    //public Square()
    //{
    //    Console.WriteLine("Square class constructor.");
    //}
    public Square() => Console.WriteLine("Square class constructor.");
    //public Square() : base() => Console.WriteLine("Square class constructor.");
}


/*
 Console.WriteLine("---5.P7---");
class Polygon
{
   sealed int _flag = 1;//error
   //sealed Polygon()
   // {
   //     Console.WriteLine("Polygon class constructor.");
   // }
    sealed Polygon()=> Console.WriteLine("Polygon class constructor.");//error
    
}
*/
