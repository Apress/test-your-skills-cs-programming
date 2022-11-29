Console.WriteLine("---4.T2---");
Console.WriteLine("***Class and Object Demo in C#.***");
// Creating an object of Sample
//Sample sample1 = new Sample(5);
Sample sample1 = new(5); // OK
Console.WriteLine($"sample1._id={sample1._id}");

class Sample
{
    internal int _id;
    public Sample(int id)
    {
        this._id = id;

    }
}

