Console.WriteLine("---7.P9---"); 
Game game = new();
Console.WriteLine($"The game name: {game.Name}");
game = new() { Name="Airplane Simulator"};
Console.WriteLine($"The new game name: {game.Name}");

class Game
{
    private string _name;
    public Game() { _name = "Car Simulator"; }
    public string Name
    {
        get => _name;

        init => _name = value;

    }
}

