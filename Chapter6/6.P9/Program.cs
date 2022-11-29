Console.WriteLine("---6.P9---");
abstract class Shape
{
    public abstract void AboutMe();

    public abstract void ShowArea();

}
//class Polygon : Shape // ERROR CS0534
abstract   class Polygon : Shape  // OK now
{
    public override void AboutMe() =>
        Console.WriteLine("Polygon");
}

