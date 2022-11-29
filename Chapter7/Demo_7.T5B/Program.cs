Console.WriteLine("---7.T5B---");
Console.WriteLine("Properties.Demo-1.Alternative Implementation(s).");
Game game = new();
//game._score = 10;//Error CS0122: it is inaccessible
//Setting  a new value
game.Score = 70;// Ok.
//Reading the value
Console.WriteLine($"Current score:{game.Score}");

//class Game
//{
//    private int _score; // The "backing" field
//    public int Score // The public property
//    {
//        get => _score;
//        set => _score = value;
//    }
//}

class Game
{
    public int Score
    {
        get; set;
    }
}






