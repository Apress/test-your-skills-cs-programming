Console.WriteLine("---9.P12---");

Circle circle = new();
Rectangle rectangle = new();
Console.WriteLine($"Is the circle a special type of shape? {circle is Shape}");
Console.WriteLine($"Is the circle a special type of rectangle? {circle is Rectangle}");
class Shape { }
class Circle : Shape { }
class Rectangle : Shape { }

