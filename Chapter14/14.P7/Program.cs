Console.WriteLine("---14.P7---");
Thread.CurrentThread.Name = "main";
Console.WriteLine($"The {Thread.CurrentThread.Name} thread with priority {Thread.CurrentThread.Priority} is executing now.");

Thread threadOne = new(
    () =>
    {
        Console.WriteLine($"The {Thread.CurrentThread.Name} with priority {Thread.CurrentThread.Priority} is executing now.");
        for (int i = 0; i < 5; i++)
        {
            // Some code 
        }
        Console.WriteLine($"The {Thread.CurrentThread.Name} is about to finish.");
    }
    );
threadOne.Name = "thread-one";
threadOne.Priority = ThreadPriority.Highest;

Console.WriteLine($"Starting {threadOne.Name} shortly.");
// threadOne starts
threadOne.Start();
Thread.Sleep(1);
Console.WriteLine($"The end of the {Thread.CurrentThread.Name} thread.");

