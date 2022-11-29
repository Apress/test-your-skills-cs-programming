Console.WriteLine("\n---2.T2---");
string name= "John";
double balance = 250.56;
// Using formatting
Console.WriteLine("Hi {0}, you have ${1} left.", name, balance);

// Using String.Format
string str = String.Format("Hi {0}, you have ${1} left.", name, balance);
Console.WriteLine(str);

// Using string concatenation
Console.WriteLine("Hi " + name + ", you have $" + balance + " left.");

// Using string interpolation (C# 6 onwarrds)
Console.WriteLine($"Hi {name}, you have ${balance} left.");
Console.WriteLine("\n---End of 2.T2---");


Console.WriteLine("\n---2.T5---");
string[] animalStore = { "Tigers","Lions","Elephants" };

string animals = string.Concat(animalStore);
Console.WriteLine($"The circus has {animals}");

animals = string.Join(",", animalStore);
Console.WriteLine($"The circus has {animals}");

Console.WriteLine("\n---End of 2.5---");

Console.WriteLine("\n---2.T6---");
string str1 = "Hello reader!";
string str2 = "Hello reader!";
string str3 = "reader!";
string str4 = "Hello " + str3;
Console.WriteLine(object.ReferenceEquals(str1,str2)); // True
Console.WriteLine(object.ReferenceEquals(str1, str4)); // False

Console.WriteLine("\n---End of T2.6---");

