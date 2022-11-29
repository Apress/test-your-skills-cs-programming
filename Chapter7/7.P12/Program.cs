Console.WriteLine("---7.P12---");
Console.WriteLine("***Indexer Demo.***");
Animals animals = new();
Console.WriteLine("Here are the animals:");
Console.WriteLine(animals[0]);
Console.WriteLine(animals[1]);

//Console.WriteLine(animals[2]);// Will cause run-time error in this program
//animals[2] = "Cat"; // Will cause run-time error in this program

class Animals
{
    private string[] _names;
    public Animals()
    {
        _names = new string[] { "Tiger", "Lion" };
    }
    public string this[int index]
    {
        get => _names[index];

        set => _names[index] = value;

    }
}