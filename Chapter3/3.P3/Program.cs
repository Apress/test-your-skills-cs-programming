Console.WriteLine("\n---3.P3---");
TrafficLight light0 = TrafficLight.Red;
Console.WriteLine($"The integral value of {light0} is {(int)light0}");

//Console.WriteLine($"The integral value of {TrafficLight.Green} is {(int)TrafficLight.Green}");
//Console.WriteLine($"The integral value of {TrafficLight.Yellow} is {(int)TrafficLight.Yellow}");

var light1 = (TrafficLight)1;
Console.WriteLine($"The light1 is {light1}");  // Green

var light2 = (TrafficLight)2;
Console.WriteLine($"The light2 is {light2}"); // 2

var light3 = (TrafficLight)3;
Console.WriteLine($"The light3 is {light3}"); // 3

var light75 = (TrafficLight)75;
Console.WriteLine($"The light75 is {light75}"); // 75

enum TrafficLight : byte
{
    Red,
    Green,
    Yellow
};