Console.WriteLine("\n---3.P7---");
foreach (Numbers num in Enum.GetValues(typeof(Numbers)))
{
    Console.WriteLine($"{num} has stored {(int)num}");
}

enum Numbers
{
    Num1 = 75,
    Num2 = -17,
    Num3,
    Num4=0,
    Num5=95,
    //Num6 = -7,
    //Num7 = 2
};
