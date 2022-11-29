Console.WriteLine("---14.P3---");
Thread.CurrentThread.Name = "main";
Console.WriteLine($"The {Thread.CurrentThread.Name} thread has started.");

Thread threadOne = new(Sample.ExecuteMethod1);
threadOne.Name = "thread-one";

Thread threadThree = new(Sample.ExecuteMethod3);
// Same as
// Thread threadThree = new Thread(Sample.ExecuteMethod3);
// Also same as
//Thread threadThree = new Thread(new ParameterizedThreadStart(Sample.ExecuteMethod3)); // OK
//Thread threadThree = new Thread(new ThreadStart(Sample.ExecuteMethod3)); // ERROR CS0123
threadThree.Name = "thread-three";

Console.WriteLine($"Starting {threadOne.Name} shortly.");
// threadOne starts
threadOne.Start();
Console.WriteLine($"Starting {threadThree.Name} shortly.");
// threadThree starts
threadThree.Start(25);

// Waiting for threadOne to finish
threadOne.Join();
// Waiting for threadtwo to finish
threadThree.Join();

Console.WriteLine("End of the Main method.");
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
    public static void ExecuteMethod3(object? number)
    {
        //int upperLimit = (int)number;
        int upperLimit = Convert.ToInt32(number);
        for (int i = upperLimit-3; i < upperLimit; i++)
        {
            Console.WriteLine($"The {Thread.CurrentThread.Name} from ExecuteMethod3 prints {i}");
            Thread.Sleep(1);
        }
    }
}

