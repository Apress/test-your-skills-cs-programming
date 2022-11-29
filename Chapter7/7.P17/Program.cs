Console.WriteLine("---7.P17---"); 
Rectangle rect = new(5.5,10);
Console.WriteLine($"The area of the rectangle is {rect.Area} square units.");


class Rectangle
{
    double length, breadth;
    public Rectangle(double length, double breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }
    public double Area
    {
        get => length * breadth;
    }
}
