Console.WriteLine("---7.P8---"); 
Console.WriteLine("Experiment with the 'init' keyword.");
Game game = new();
//game.Name = "SuperGame2";//ERROR CS8852
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
