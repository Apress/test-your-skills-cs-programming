Console.WriteLine("---14.P15---");
Thread.CurrentThread.Name = "main";
Console.WriteLine($"The {Thread.CurrentThread.Name} thread has started.");

CancellationTokenSource cts = new();


//Thread threadThree = new(Sample.ExecuteMethod3);
//threadThree.Name = "thread-three";
//Console.WriteLine($"Starting {threadThree.Name} shortly.");
//// threadThree starts
//threadThree.Start(cts.Token);
//// Let threadThree run for some time
//Thread.Sleep(1000);

// Using ThreadPool class
ThreadPool.QueueUserWorkItem(Sample.ExecuteMethod3, cts.Token);
//ThreadPool.QueueUserWorkItem(new WaitCallback(Sample.ExecuteMethod3), cts.Token);
Thread.Sleep(1000);


Console.WriteLine("About to set the cancellation request.");
cts.Cancel();
Thread.Sleep(1000);

// CancellationTokenSource implements IDisposable
// So, we can call the Dispose() method
cts.Dispose();

Console.WriteLine("Control comes at the end of the Main method.");
class Sample
{   
    public static void ExecuteMethod3(object? token)
    {
        CancellationToken cToken = (CancellationToken)token;     
        for (int i = 0; i < 100000; i++)
        {
           if (cToken.IsCancellationRequested)
            {
                Console.WriteLine($"\tThe {Thread.CurrentThread.Name} was executing ExecuteMethod3.");
                Console.WriteLine($"\tIn iteration {i+1}, the cancellation has been requested.");
                // Some cleanup operation
                break;
            }
            // SpinWait causes a thread to wait for the number of times defined by the iterations parameter
            Thread.SpinWait(500000);
        }
    }
}