Console.WriteLine("---15.P2---");
//int? score = 75;
//int? score = 40;
int? score = null;
string message = $"Score: {score} Remarks: {
score switch
{
    >= 60 => "First division",
    >= 40 => "Second division",
    _ => "Failed.",
}
}";
Console.WriteLine(message);

#region Alternative implementation

//CheckNumber(75);
CheckNumber(40);
//CheckNumber(27);

void CheckNumber(double score)
{
    switch (score)
    {
        case >= 60:
            Console.WriteLine($"Score: {score} Remarks: First division.");
            break;
        case >= 40:
            Console.WriteLine($"Score: {score} Remarks: Second division.");
            break;
        default:
            Console.WriteLine($"Score: {score} Remarks: Failed.");
            break;     
        
    }
}
#endregion
