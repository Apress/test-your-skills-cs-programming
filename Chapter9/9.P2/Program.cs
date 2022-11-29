Console.WriteLine("---9.P2---");
//Console.WriteLine("Exploring static data.");
double length = 15.5;
double breadth = 7;
double area = Rectangle.GetArea(length, breadth);
//double area = new Rectangle().GetArea(length, breadth); // ERROR CS0176
Console.WriteLine($"The rectangle's area is {area} square unit.");
//static class Rectangle
class Rectangle
{
    public static double GetArea(double len, double bre)
    {
        return len * bre;
    }
}
