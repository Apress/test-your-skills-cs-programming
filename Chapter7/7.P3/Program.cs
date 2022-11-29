Console.WriteLine("---7.P3---"); 
Game game = new();
Console.WriteLine($"Current level: {game.Level}");
game.Level = 2;
Console.WriteLine($"Current level: {game.Level}");
game.Level = 3;
Console.WriteLine($"Current level: {game.Level}");

class Game
{
    private int level=1;
    public int Level
    {
        get => level;

        set
        {
            if (value < 0 || value> 2)
            { level = 0; }
            else { level = value; }
        }

    }
}
