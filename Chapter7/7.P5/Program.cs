Console.WriteLine("---7.P5---"); 
Console.WriteLine("Experimenting with a virtual property in C#.");
Shape shape = new();
Console.WriteLine($"The area of the {shape} is {shape.Area} square units.");
shape = new Circle(10);
Console.WriteLine($"The area of the {shape} is {shape.Area} square units.");
//Circle circle = new Circle(10);
//Console.WriteLine($"The area of the {shape} is {circle.Area} square units.");

class Shape
{
    public virtual double Area
    {
        get => 0;
    }
    public override string ToString()
    {
        return "unknown shape";
    }
}
class Circle : Shape
{
    readonly int _radius;
    public Circle(int radius)
    {
        this._radius = radius;

    }
    public int Radius
    {
        get => _radius;
    }
    public override double Area
    {
        get => 3.14 * _radius * _radius;
    }
    //public new double Area
    //{
    //    get => 3.14 * _radius * _radius;
    //}
    public override string ToString()
    {
        return "circle";
    }
}

