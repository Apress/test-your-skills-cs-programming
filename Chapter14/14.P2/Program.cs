Console.WriteLine("---14.P2---");
Thread.CurrentThread.Name = "main";
Console.WriteLine($"The {Thread.CurrentThread.Name} thread has started.");

Thread threadOne = new(Sample.ExecuteMethod1);
threadOne.Name = "thread-one";

Thread threadTwo = new(Sample.ExecuteMethod2);
threadTwo.Name = "thread-two";

Console.WriteLine($"Starting {threadOne.Name} shortly.");
// threadOne starts
threadOne.Start();
Console.WriteLine($"Starting {threadTwo.Name} shortly.");
// threadTwo starts
threadTwo.Start();

// Waiting for threadOne to finish
threadOne.Join();
// Waiting for threadtwo to finish
threadTwo.Join();


Console.WriteLine("Control comes at the end of the Main method.");
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
    public static void ExecuteMethod2()
    {
        for (int i = -5; i < 0; i++)
        {
            Console.WriteLine($"The {Thread.CurrentThread.Name} from ExecuteMethod2 prints {i}");
            Thread.Sleep(1);
        }
    }
}