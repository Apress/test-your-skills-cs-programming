Console.WriteLine("---11.P3---");
Sender sender = new();
Receiver receiver = new();
// Receiver registers for a notification from sender
Console.WriteLine("Registering the notification event.");
sender.FlagChanged += receiver.GetNotification;

Console.WriteLine("Setting the flag to 1.");
sender.Flag = 1;
Console.WriteLine("Unregistering the event.");
sender.FlagChanged -= receiver.GetNotification;

// You can create a subclass of System.EventArgs too
class FlagEventArgs
{
    int _currentFlag;
    public int CurrentFlag
    {
        get { return _currentFlag; }
        set { _currentFlag = value; }
    }
}


class Sender
{
    // public delegate void FlagChangedEventHandler(object? sender, FlagEventArgs eventArgs);
    // private event FlagChangedEventHandler? InnerFlagChanged;// To support Naming conventions
    // public event FlagChangedEventHandler? FlagChanged
    private event Action<object?, FlagEventArgs>? InnerFlagChanged;
    public event Action<object?, FlagEventArgs>? FlagChanged
    {
        add
        {
            Console.WriteLine("The entry point of the add accessor.");
            InnerFlagChanged += value;
        }
        remove
        {
            InnerFlagChanged -= value;
            Console.WriteLine("The exit point of the remove accessor.");
        }
    }


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
    public void OnFlagChanged()
    {
        FlagEventArgs flagEventArgs = new();
        flagEventArgs.CurrentFlag = _flag;
        InnerFlagChanged?.Invoke(this, flagEventArgs);
    }
}

class Receiver
{
    public void GetNotification(object? sender, FlagEventArgs e)
    {
        Console.WriteLine($"\nALERT: The flag value is changed to {e.CurrentFlag}.");
    }
}