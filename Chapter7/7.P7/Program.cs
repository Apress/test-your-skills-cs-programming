Console.WriteLine("---7.P7---"); 
Console.WriteLine("Experiment with the 'init' keyword.");
Game game = new();
Console.WriteLine($"Game name: {game.Name}");
class Game
{
    private string _name;
    public Game() { _name = "SuperGame"; }
    public string Name
    {
        get => _name;

        init => _name = value;

    }
}