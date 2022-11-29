Console.WriteLine("---14.P14---");
Thread.CurrentThread.Name = "main";
Console.WriteLine($"The {Thread.CurrentThread.Name} thread has started.");

//ThreadPool.QueueUserWorkItem(new WaitCallback(Sample.ExecuteMethod)); // ERROR CS0123
//ThreadPool.QueueUserWorkItem(new WaitCallback(Sample.ExecuteMethod3)); // OK

//Console.WriteLine(Convert.ToInt32(null));

Console.WriteLine("Control comes at the end of the Main method.");
class Sample
{
    public static void ExecuteMethod()
    {
        // Some code
    }
    //public static void ExecuteMethod3(object? number)
    //{
    //    // Some code
    //}
}
