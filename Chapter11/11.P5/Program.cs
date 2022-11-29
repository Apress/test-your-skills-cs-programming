Console.WriteLine("---11.P5---");
Sender sender = new();
Receiver receiver = new();
// Receiver registers for a notification from the sender
((ISender)sender).FlagChanged += receiver.GetNotification;
Console.WriteLine("Setting the flag to 1.");
sender.Flag = 1;
Console.WriteLine("Setting the flag to 2.");
sender.Flag = 2;
// Unregistering now
((ISender)sender).FlagChanged -= receiver.GetNotification;
interface ISender
{
    event EventHandler? FlagChanged;
}
class Sender : ISender
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
    private event EventHandler? FlagChanged;
    event EventHandler? ISender.FlagChanged
    {
        add
        {
            Console.WriteLine(" The entry point of the add accessor.");
            FlagChanged += value;
        }

        remove
        {
            FlagChanged -= value;
            Console.WriteLine(" The exit point of the remove accessor.");
        }
    }

    //public event EventHandler? FlagChanged;

    public void OnFlagChanged()
    {
        //if (FlagChanged != null)
        //{
        //    FlagChanged(this, EventArgs.Empty);
        //}

        // Simplified form:
        FlagChanged?.Invoke(this, EventArgs.Empty);
    }

}
class Receiver
{
    public void GetNotification(object? sender, System.EventArgs e)
    {
        Console.WriteLine($"ALERT: The flag value is changed in the Sender.");
    }
}
