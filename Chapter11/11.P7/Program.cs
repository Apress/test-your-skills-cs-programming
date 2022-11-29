Console.WriteLine("---11.P7---");
Sender sender = new();
Receiver receiver = new();
// Receiver registers for a notification from sender
sender.FlagChanged += receiver.GetNotification;

Console.WriteLine("Setting flag to 1.");
sender.Flag = 1;
Console.WriteLine("Setting flag to 2.");
sender.Flag = 2;

// Using this class to pass an event argument.
class FlagEventArgs:EventArgs
{
    int _currentFlag;
    public int CurrentFlag
    {
        get { return _currentFlag; }
        set { _currentFlag = value; }
    }
}

abstract class ParentSender
{
    public abstract event EventHandler<FlagEventArgs>? FlagChanged;

}

class Sender : ParentSender
{
    public override event EventHandler<FlagEventArgs>? FlagChanged;

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
        Console.WriteLine($"ALERT:The flag value is changed to {e.CurrentFlag}.");
    }
}
