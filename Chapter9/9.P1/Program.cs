Console.WriteLine("---9.P1---");
//Console.WriteLine("Exploring static data.");
double length = 15.5;
double breadth = 7;
double area = Rectangle.GetArea(length, breadth);
Console.WriteLine($"The rectangle's area is {area} square units.");
class Rectangle
{
    public static double GetArea(double len, double bre)
    {
        return len * bre;
    }
}
