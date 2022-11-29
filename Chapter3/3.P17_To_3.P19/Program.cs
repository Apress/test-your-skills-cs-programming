Console.WriteLine("\n---3.P17, 3.P18 and 3.P19---");
// 3.P17
struct Codes
{
    // C# 10 onwards, this is OK; otherwise you see CS8773 error
    public Codes()
    {
        // Some code
    }
}

// 3.P18
struct Codes2
{
    //Codes2() // Error CS8958
    //{
    //    // Some code
    //}
}

// 3.P19
struct Codes3
{
    //protected int _error; // Error CS0666
    //public virtual void SomeMethod() { } // Error CS0106
    //public abstract void SomeMethod(); // Error CS0106
}
