Console.WriteLine("---14.P13---");
Thread.CurrentThread.Name = "main";
Console.WriteLine($"The {Thread.CurrentThread.Name} thread has started.");

Thread threadOne = new(Sample.ExecuteMethod1);
threadOne.Name = "thread-one";
Console.WriteLine($"Starting {threadOne.Name} shortly.");
// threadOne starts
threadOne.Start();

// Using ThreadPool class
//ThreadPool.QueueUserWorkItem(Sample.ExecuteMethod3);
ThreadPool.QueueUserWorkItem(Sample.ExecuteMethod3, 10);
//ThreadPool.QueueUserWorkItem(new WaitCallback(Sample.ExecuteMethod3), 10);

//Sample.ExecuteMethod1();
//// Waiting for threadOne to finish
//threadOne.Join();
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
    public static void ExecuteMethod3(object? number)
    {
        //int upperLimit = (int)number;
        int upperLimit = Convert.ToInt32(number);
        for (int i = upperLimit - 3; i < upperLimit; i++)
        {
            Console.WriteLine($"The {Thread.CurrentThread.Name} from ExecuteMethod3 prints {i}");
            Thread.Sleep(1);
        }
    }
}
