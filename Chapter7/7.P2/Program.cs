Console.WriteLine("---7.P2---"); 
Console.WriteLine("Experimenting properties in C#.");
Game game = new();
//game.Level = 2; // ERROR CS0272

class Game
{
    private int level;
    //public Game() { level = 1; } // OK
    public int Level
    {
        get => level;

        private set => level = value;

    }
}
