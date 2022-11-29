Console.WriteLine("---14.P9---");

Console.WriteLine("Exploring a non-synchronized version.****");
Thread.CurrentThread.Name = "main thread";
Console.WriteLine($"The {Thread.CurrentThread.Name} is executing now.");

SharedResource sharedObject = new();
Thread threadOne = new(sharedObject.ExecuteSharedMethod);
threadOne.Name = "Child thread-1";

Thread threadTwo = new(sharedObject.ExecuteSharedMethod);
threadTwo.Name = "Child thread-2";
// Child Thread-1 starts.
threadOne.Start();
// Child Thread-2 starts.
threadTwo.Start();
// Waiting for Child thread-1 to finish.
threadOne.Join();
// Waiting for Child thread-2 to finish.
threadTwo.Join();
Console.WriteLine($"The {Thread.CurrentThread.Name} is about to finish.");
class SharedResource
{
    public void ExecuteSharedMethod()
    {
        Console.WriteLine(Thread.CurrentThread.Name + " has entered the shared location.");
        Thread.Sleep(1000);
        Console.WriteLine(Thread.CurrentThread.Name + " exits.");
    }
}


