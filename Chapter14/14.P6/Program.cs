Console.WriteLine("---14.P6---");
Console.WriteLine("Handling a method(using lambda expression) that accepts a parameter and returns an int.");
Console.WriteLine("Running this method in a different thread.");
Thread.CurrentThread.Name = "main";
int input = 0; // A initial value
Console.WriteLine($"The initial value of the input is {input}");
//Console.WriteLine($"Inside the {Thread.CurrentThread.Name} thread, the ManagedThreadId is {Thread.CurrentThread.ManagedThreadId}"); //NOT Recommended now
Console.WriteLine($"Inside the {Thread.CurrentThread.Name} thread, the ManagedThreadId is {Environment.CurrentManagedThreadId}"); //Recommended nowadays
Thread threadOne = new(
    (a) =>
        {
            Console.WriteLine($"The {Thread.CurrentThread.Name} is executing now.");
            // Do some activity if required      
            try
            {
                int temp = Convert.ToInt32(a);
                input = temp + 5;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception:{e}");
            }
        }
    );
threadOne.Name = "thread-one";

Console.WriteLine($"Starting {threadOne.Name} shortly.");
// threadOne starts
threadOne.Start(10);

// Waiting for threadOne to finish
threadOne.Join();

Console.WriteLine($"The current value of the input is {input}");
Console.WriteLine($"End of the {Thread.CurrentThread.Name} thread.");

