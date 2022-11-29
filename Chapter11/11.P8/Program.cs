Console.WriteLine("---11.P8---");
class FlagEventArgs : EventArgs
{
    int _currentFlag;
    public int CurrentFlag
    {
        get { return _currentFlag; }
        set { _currentFlag = value; }
    }
}

class ParentSender2
{
    public virtual event EventHandler<FlagEventArgs>?
                                                   FlagChanged;
}

class ParentSender3 : ParentSender2
{
    //public sealed event EventHandler<FlagEventArgs>? FlagChanged; // ERROR CS0238
    public override sealed event EventHandler<FlagEventArgs>? FlagChanged; // OK
}
// The receiver class and other code skipped

