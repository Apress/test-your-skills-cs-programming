Console.WriteLine("---14.P5---");
Thread.CurrentThread.Name = "main";
Console.WriteLine($"The {Thread.CurrentThread.Name} thread has started.");

Thread threadOne = new(Sample.ExecuteMethod1);
threadOne.Name = "thread-one";

Thread threadFour= new(Sample.ExecuteMethod4);
threadFour.Name = "thread-four";

Console.WriteLine($"Starting {threadOne.Name} shortly.");
// threadOne starts
threadOne.Start();
Console.WriteLine($"Starting {threadFour.Name} shortly.");
// threadFour starts
//threadFour.Start(new Boundaries(7, 11)); // Valid input
threadFour.Start(new Boundaries(17, 11)); // Invalid input


// Waiting for threadOne to finish
threadOne.Join();
// Waiting for threadtwo to finish
threadFour.Join();

Console.WriteLine("End of the Main method.");
class Boundaries
{
    public int lowerLimit;
    public int upperLimit;
    public Boundaries(int lower, int upper)
    {
        lowerLimit = lower;
        upperLimit = upper;
    }
}

class Sample
{
    public static void ExecuteMethod1()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"The {Thread.CurrentThread.Name} from ExecuteMethod1 prints {i}");
            Thread.Sleep(1);
        }
    }
    public static void ExecuteMethod4(object? limits)
    {
        Boundaries? boundaries = limits as Boundaries;
        if (boundaries != null)
        {
            int lowerLimit = boundaries.lowerLimit;
            int upperLimit = boundaries.upperLimit;
            if (lowerLimit <= upperLimit)
            {
                for (int i = lowerLimit; i < upperLimit; i++)
                {
                    Console.WriteLine($"The {Thread.CurrentThread.Name} from ExecuteMethod4 prints {i}");
                    Thread.Sleep(1);
                }
            }
            else
            {
                Console.WriteLine("The lower limit cannot be greater than the upper limit.");
            }

        }       

    }
}