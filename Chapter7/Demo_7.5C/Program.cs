Console.WriteLine("---7.T5C---");
Console.WriteLine("Properties Demo.Alternative Implementation.");
Game game = new();
// Get the default value
Console.WriteLine($"Current score:{game.Score}");
// Set  a new value
game.Score = 70; // OK

// Read the current value
Console.WriteLine($"Current score:{game.Score}");

class Game
{   
    public int Score // The public property
    {
        get; set;
    } = 60;
}



