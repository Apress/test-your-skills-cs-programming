Console.WriteLine("---12.P9---");
Sender sender = new Sender();

Console.WriteLine("Registering the event.");
// Using lambda expression as an event handler
// Bad practise
sender.MyIntChanged += (object sender, System.EventArgs e) =>
                          Console.WriteLine("The flag is changed.");
// Better practise
// EventHandler myEvent =
//  (object sender, EventArgs e) => Console.WriteLine("The flag is changed.");
// sender.MyIntChanged += myEvent;
Console.WriteLine("Setting the flag to 1.");
sender.Flag = 1;
Console.WriteLine("Setting the flag to 2.");
sender.Flag = 2;
Console.WriteLine("\nUnregistering the event.");
// Unregistering now
// but there is no guarantee if you follow the bad practise
sender.MyIntChanged -= (object sender, System.EventArgs e) =>
                          Console.WriteLine("Unregistered event notification.");

Console.WriteLine("Setting the flag to 3.");
sender.Flag = 3;
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
            OnMyIntChanged();
        }
    }

    public event EventHandler? MyIntChanged;
    public void OnMyIntChanged()
    {
        MyIntChanged?.Invoke(this, EventArgs.Empty);
    }
}
