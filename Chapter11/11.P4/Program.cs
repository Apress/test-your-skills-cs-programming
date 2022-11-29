Console.WriteLine("---11.P4---");
Sender sender = new ();
Receiver receiver = new();
// Receiver registers for a notification from the sender
sender.FlagChanged += receiver.GetNotification;
Console.WriteLine("Setting the flag to 1.");
sender.Flag = 1;
Console.WriteLine("Setting the flag to 2.");
sender.Flag = 2;
// Unregistering now
sender.FlagChanged -= receiver.GetNotification;

interface ISender
{
    event EventHandler? FlagChanged;
}
class Sender:ISender
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
      FlagChanged?.Invoke(this, EventArgs.Empty);
    }
   
}
class Receiver
{
    public void GetNotification(object? sender,System.EventArgs e)
    {
        Console.WriteLine($"ALERT: The flag value is changed in the Sender.");
    }
}
