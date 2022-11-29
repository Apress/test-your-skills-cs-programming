Console.WriteLine("---14.P8---");
Thread.CurrentThread.Name = "main thread";
Console.WriteLine($"The {Thread.CurrentThread.Name} is executing now.");
Thread childThread = new(
    () =>
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"The {Thread.CurrentThread.Name}  prints {i}");
            Thread.Sleep(500);      
        }
        
        Console.WriteLine($"The {Thread.CurrentThread.Name} is about to finish.");
    }
    );
childThread.Name = "child thread";
Console.WriteLine($"Starting a {childThread.Name} shortly.");
// threadOne starts
childThread.Start();
childThread.IsBackground = true;
//childThread.Join();
Console.WriteLine($"The end of the {Thread.CurrentThread.Name}.");
