Console.WriteLine("---12.P11---");

// Code Segment-1
Func<string, double> del = (string s) => double.Parse(s);
double flag2 = del("23.4");
Console.WriteLine(flag2);

// Code Segment-2
var flag1 = (string s) => double.Parse(s);
Console.WriteLine(flag1("23.4"));

