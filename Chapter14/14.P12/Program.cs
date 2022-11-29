Console.WriteLine("---14.P12---");
Console.WriteLine("Exploring a potential deadlocked situation.");
Thread.CurrentThread.Name = "Main thread";
Console.WriteLine("The main thread has started already.");

SharedResource sharedObject = new();
Thread threadOne = new(sharedObject.MethodOne);
threadOne.Name = "Child thread-1";

Thread threadTwo = new(sharedObject.MethodTwo);
threadTwo.Name = "Child thread-2";
// Child Thread-1 starts.
threadOne.Start();
// Child Thread-2 starts.
threadTwo.Start();
// Waiting for Child Thread-1 to finish.
threadOne.Join();
// Waiting for Child Thread-2 to finish.
threadTwo.Join();
Console.WriteLine($"The {Thread.CurrentThread.Name} exits now.");

class SharedResource
{
    private object firstLock = new();
    private object secondLock = new();
    public void MethodOne()
    {
        lock (firstLock)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} enters into MethodOne(Part-1).");
            //Thread.Sleep(500);
            Console.WriteLine($"{Thread.CurrentThread.Name} exits MethodOne(Part-1).");
            lock (secondLock)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} has entered MethodOne(Part-2).");
                //Thread.Sleep(500);
                Thread.Yield();
                Console.WriteLine($"{Thread.CurrentThread.Name} exits MethodOne(Part-2).");
            }
        }

    }
    public void MethodTwo()
    {
        lock (secondLock)
        {

            Console.WriteLine($"{Thread.CurrentThread.Name} enters into MethodTwo(Part-I).");
            //Thread.Sleep(500);
            Console.WriteLine($"{Thread.CurrentThread.Name} exits MethodTwo(Part-1).");
            lock (firstLock)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} has entered MethodTwo(Part-II).");
                Thread.Sleep(500);
                //Thread.Yield();
                Console.WriteLine($"{Thread.CurrentThread.Name} exits MethodTwo(Part-2).");
            }
        }
    }
}


