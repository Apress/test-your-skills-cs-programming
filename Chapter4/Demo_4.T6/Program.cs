Console.WriteLine("---9.T1---");
// Console.WriteLine("***Default constructor demo.***");
// Creating an object of Sample
Sample sample = new Sample();
Console.WriteLine($"The variable _flag is initialized with {sample._flag}.");

class Sample
{
    internal int _flag;
    internal Sample()
    {
        this._flag = 10;
    }

}

