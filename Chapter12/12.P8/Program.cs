Console.WriteLine("---12.P8---");
Sender sender = new Sender();

// Using lambda expression as an event handler
// Bad practise
// sender.MyIntChanged += (object sender, System.EventArgs e) =>
// Console.WriteLine("Using lambda expression, inside Main method, received a notification: Sender recently has changed the myInt value . ");

// Better practise
EventHandler myEvent =
  (object sender, EventArgs e) => Console.WriteLine("The flag is changed.");
Console.WriteLine("Registering the event.");
sender.MyIntChanged += myEvent;
Console.WriteLine("Setting the flag to 1.");
sender.Flag = 1;
Console.WriteLine("Setting the flag to 2.");
sender.Flag = 2;
// Unregistering now
// but there is no guarantee if you follow the bad practise
// sender.MyIntChanged -= (Object sender, System.EventArgs e) =>
// Console.WriteLine("Unregistered event notification.");

Console.WriteLine("\nUnregistering the event.");
// But now it can remove the event properly.
sender.MyIntChanged -= myEvent;
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
                _flag= value;            
                OnMyIntChanged();
            }
        }
       
        public event EventHandler? MyIntChanged;
        public void OnMyIntChanged()
        {
            MyIntChanged?.Invoke(this, EventArgs.Empty);
        }
    }




