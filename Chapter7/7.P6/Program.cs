Console.WriteLine("---7.P6---"); 
Console.WriteLine("Experimenting with an abstract property in C#.");
Shape shape = new Rectangle();
Console.WriteLine($"The area of the {shape} is {shape.Area} square units.");

abstract class Shape
{
    public abstract double Area { get; }

    public override string ToString()
    {
        return "unknown shape";
    }
}
class Rectangle : Shape
{
    public override double Area
    {
        get => 100;
    }
    public override string ToString()
    {
        return "rectangle";
    }

}

