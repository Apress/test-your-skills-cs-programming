Console.WriteLine("---9.P3---");

//static class Rectangle
static class Rectangle
{
    readonly static int _flag = 20;
    public static void CalculateArea()
    {
        Console.WriteLine("The area is shown.");
    }

    //// CS0708
    //public void DisplaySomethingElse()
    //{
    //    Console.WriteLine("Display something (except area).");
    //}
}

// Non-static class Rectangle2
class Rectangle2
{
    // NO ERROR
    public static void CalculateArea()
    {
        Console.WriteLine("The area is shown.");
    }

    public void DisplaySomethingElse()
    {
        Console.WriteLine("Display something (except area).");
    }
}


