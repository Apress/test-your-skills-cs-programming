Console.WriteLine("\n---3.P21---");
//Point point1 = new Point();
Point point1 = new();
Console.WriteLine($"Point_1: {point1}");

//Point point2 = default (Point);
Point point2 = default;
Console.WriteLine($"Point_2: {point2}");
struct Point
{
    int _xCoordinate = 1;
    int _yCoordinate;

    public Point()
    {
        _yCoordinate = 2;
    }
    public override string ToString() => "(" + _xCoordinate + "," + _yCoordinate + ")";
    //public override string ToString()
    //{
    //    string temp= "(" + _xCoordinate + "," + _yCoordinate + ")";
    //    return temp;
    //}
}
