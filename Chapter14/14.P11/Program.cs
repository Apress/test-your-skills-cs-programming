Console.WriteLine("---14.P11---");

Console.WriteLine("Exploring a synchronized version.");
Thread.CurrentThread.Name = "main thread";
Console.WriteLine($"The {Thread.CurrentThread.Name} is executing now.");

SharedResource sharedObject = new();
Thread threadOne = new(sharedObject.ExecuteSharedMethod);
threadOne.Name = "Child thread-1";

Thread threadTwo = new(sharedObject.ExecuteSharedMethod);
threadTwo.Name = "Child thread-2";
Random random = new Random();
if (random.Next() % 2 == 0)
{
// Child Thread-1 starts.
threadOne.Start();
// Child Thread-2 starts.
threadTwo.Start();
}
else
{
// Child Thread-2 starts.
threadTwo.Start();
// Child Thread-1 starts.
threadOne.Start();

}
// Waiting for Child Thread-1 to finish.
threadOne.Join();
// Waiting for Child Thread-2 to finish.
threadTwo.Join();
Console.WriteLine($"The {Thread.CurrentThread.Name} is about to finish.");
class SharedResource
{
    private readonly object myLock = new();
    public void ExecuteSharedMethod()
    {
        //lock (myLock)
        //{

        //    Console.WriteLine($"{Thread.CurrentThread.Name} has entered the shared location.");
        //    Thread.Sleep(1000);
        //    Console.WriteLine($"{Thread.CurrentThread.Name} exits.");
        //}
        try
        {
            Monitor.Enter(myLock);
            Console.WriteLine($"{Thread.CurrentThread.Name} has entered the shared location.");
            Thread.Sleep(1000);
            Console.WriteLine($"{Thread.CurrentThread.Name} exits.");
        }
        finally
        {
            Monitor.Exit(myLock);
        }
    }
}
