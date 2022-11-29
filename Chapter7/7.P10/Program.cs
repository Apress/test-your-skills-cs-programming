Console.WriteLine("---7.P10---"); 
Console.WriteLine("A usage of auto-implemented property with the 'init' keyword.");
Game game = new();
Console.WriteLine($"Game name: {game.Name}");
//game.Name = "Pogo";// ERROR CS8852
class Game
{
  public string Name { get; init; } = "SuperGame";
}
