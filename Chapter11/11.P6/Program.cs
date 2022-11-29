Console.WriteLine("---11.P6---");
Sender sender = new();
Receiver receiver = new();
// Receiver registers for a notification from the sender
sender.FlagChanged += receiver.GetNotification;

Console.WriteLine("Setting the flag to 5.");
sender.Flag = 5;
Console.WriteLine("Setting the flag to 7.");
sender.Flag = 7;

// Using this class to pass an event argument.
class FlagEventArgs : System.EventArgs
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
    //public delegate void FlagChangedEventHandler(object? sender, FlagEventArgs eventArgs);
    //public event FlagChangedEventHandler? FlagChanged;
    public event EventHandler<FlagEventArgs>? FlagChanged;

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
        FlagChanged?.Invoke(this, flagEventArgs);
    }
}

class Receiver
{
    public void GetNotification(object? sender, FlagEventArgs e)
    {
        Console.WriteLine($"ALERT: The flag value is changed to {e.CurrentFlag}.");
    }
}
