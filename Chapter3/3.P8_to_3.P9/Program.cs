Console.WriteLine("\n---3.P8 and 3.P9---");
foreach (Numbers num in Enum.GetValues(typeof(Numbers)))
{
    Console.WriteLine($"{num} is storing {(int)num}");
}

enum TrafficLight : byte
{
    Red,
    Green = (byte)Numbers.Num3,
    Yellow
};
enum Numbers
{
    Num1 = -12,
    Num2 = TrafficLight.Red,
    Num3,
    Num4 = 100
};

// For 3.P9
//enum Numbers
//{
//    Num1 = -12,
//    Num2 = TrafficLight.Green, 
//    Num3,
//    Num4 = 100
//};