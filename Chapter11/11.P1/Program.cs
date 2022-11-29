Console.WriteLine("---11.P1---");
Sender sender = new();
// Sender will receive its own notification now onwards.
sender.FlagChanged += sender.SelfNotification;
Console.WriteLine("Setting the flag to 1.");
sender.Flag = 1;
Console.WriteLine("Setting the flag to 2.");
sender.Flag = 2;

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
        //if (FlagChanged != null)
        //{
        //    FlagChanged(this, EventArgs.Empty);
        //}

        // Simplified form:
        FlagChanged?.Invoke(this, EventArgs.Empty);
    }

    public void SelfNotification(object? sender, System.EventArgs e)
    {
        Console.WriteLine($"Personal ALERT: The flag becomes {_flag}.");
    }
}

 