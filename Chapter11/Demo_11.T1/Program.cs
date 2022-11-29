Console.WriteLine("---11.T1---");
Sender sender = new();
Receiver receiver = new();
// Receiver registers for a notification from the sender
//sender.FlagChanged += receiver.GetNotification;
sender.FlagChanged += new EventHandler(receiver.GetNotification);// Also OK
//sender.FlagChanged += receiver.UnRelatedMethod;// For Q&A 11.T2

Console.WriteLine("Setting the flag to 1.");
sender.Flag = 1;
Console.WriteLine("Setting the flag to 2.");
sender.Flag = 2;
// Unregistering now
sender.FlagChanged -= receiver.GetNotification;
Console.WriteLine("Setting the flag to 3.");
// No notifications sent for the receiver now. 
sender.Flag = 3;
Console.WriteLine("Setting the flag to 4.");
sender.Flag = 4;
class Sender
{
    private int _flag;
    public int Flag
    {
        get
        {
            return _flag;
        }
        set
        {
            _flag = value;
            OnFlagChanged();
        }
    }

    public event EventHandler? FlagChanged;
    public void OnFlagChanged()
    {
        if (FlagChanged != null)
        {
            FlagChanged(this, EventArgs.Empty);
        }

        // Simplified form:
        // FlagChanged?.Invoke(this, EventArgs.Empty);
    }
}
class Receiver
{
    public void GetNotification(object? sender, System.EventArgs e)
    {
        Console.WriteLine($"ALERT: The flag value is changed in the Sender.");
    }
    //// For Q&A 11.T2
    //public void UnRelatedMethod()
    //{
    //    Console.WriteLine(" An unrelated method. ");
    //}

}
