Console.WriteLine("---9.P16---");
Console.WriteLine("Testing a method that returns multiple values.");
double radius = 10.0;
double area, perimeter;
string description = string.Empty;
Sample.UpdateDetails(radius, out area, out perimeter,out description);
Console.WriteLine($"The area of the circle is  {area} sq. units.");
Console.WriteLine($"The perimeter of the circle is {perimeter} units.");
Console.WriteLine($"Description: it is a {description} circle.");
class Sample
{
    public static void UpdateDetails(double x, out double area, out double peri,out string desc)
    {
        area = 3.14 * x * x;
        peri = 2 * 3.14 * x;
        desc = "filled";
    }    
}

