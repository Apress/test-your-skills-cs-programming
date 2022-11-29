Console.WriteLine("---7.P1---"); 
Console.WriteLine("Experimenting properties in C#.");
Game game = new();
Console.WriteLine($"Current level: {game.Level}");
game.Level = 2;
Console.WriteLine($"Current level: {game.Level}");
class Game
{
    private int _level;
    public Game() { _level = 1; }
    public int Level
    {
        get => _level;

        set => _level = value;

    }
}

