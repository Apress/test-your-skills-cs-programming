Console.WriteLine("---3.T5---");

//Console.WriteLine($"{(Allignment)0}");// 0
//Console.WriteLine($"{(Allignment)1}");// TowardsLeft
//Console.WriteLine($"{(Allignment)2}");// TowardsRight
Console.WriteLine("Applying casting.");

Measurement position = (Measurement)Allignment.TowardsLeft;
Console.WriteLine($"The current position is {position}"); // Middle
Console.WriteLine($"Its integral value is {(int)position}"); // 1

public enum Measurement : int
{
    Left,
    Middle,
    Right
}
public enum Allignment : uint
{
    TowardsLeft = 1,
    TowardsRight = 2,
}

