Console.WriteLine("---9.T10---");
Console.WriteLine("***Indexer Demo.***");
Animals animals = new();
Console.WriteLine("Here are the animals:");
Console.WriteLine(animals[0]);
Console.WriteLine(animals[1]);

// Updating the animal type at index 0
animals[0] = "Cat";
Console.WriteLine("The updated list of the animals:");
Console.WriteLine(animals[0]);
Console.WriteLine(animals[1]);


class Animals
{
    private string[] _names;
    public Animals()
    {
        _names = new string[] { "Tiger", "Lion" };
    }
    public string this[int index]
    {
        get
        {
            string temp = String.Empty;
            if (index >= 0 && index < _names.Length)
            {
                temp = _names[index];
            }
            else
            {
                // You can throw an error
            }

            return temp;
        }
        set
        {
            if (index >= 0 && index < _names.Length)
            {

                _names[index] = value;
            }
            else
            {
                // You can throw an error
            }

        }
    }
}


