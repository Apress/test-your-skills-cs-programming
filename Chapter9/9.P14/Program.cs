Console.WriteLine("---9.P14---");
Shape shape = new();
Circle circle = new();
Shape? convertedShape = circle as Shape;
Console.WriteLine($" The conversion 'circle as Shape' produces {convertedShape}");
Circle? convertedCircle = shape as Circle;
if (convertedCircle == null)
{
    Console.WriteLine($" The conversion 'shape as Circle' produces null.");
}
else
{
    Console.WriteLine($" The conversion 'shape as Circle' produces {convertedCircle}");
}
//convertedShape = circle as Rectangle;
class Shape { }
class Circle : Shape { }
class Rectangle : Shape { }

