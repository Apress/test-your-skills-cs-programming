Console.WriteLine("---7.P4---"); 
Game game = new();
Console.WriteLine($"The current level: {game.Level}");
game.Level = 3;
Console.WriteLine($"The current level: {game.Level}");

class Game
{
    public int Level
    {
        get; set;

    } = 2;
}
