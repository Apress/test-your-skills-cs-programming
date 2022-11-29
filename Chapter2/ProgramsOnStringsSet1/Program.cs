// Programs on Strings
Console.WriteLine("---2.P1---");
string text1 = string.Concat("Hello", "World!");
Console.WriteLine("The text is: " + text1);
Console.WriteLine($"The text is: {text1}");
Console.WriteLine("\n---End of 2.P1---");

Console.WriteLine("\n---2.P2---");
string text2 = "test";
Console.Write($"The length of 'text2' is: {text2.Length}");
for (int i = 0; i < text2.Length; i++)
{
    Console.Write($"\nThe text2[{i}] contains: {text2[i]}");
}

//// Alternative Solution:
//string text2 = "test";
//foreach (char c in text2)
//{
//    Console.WriteLine(c);
//}

Console.WriteLine("\n---End of 2.P2---");


Console.WriteLine("\n---2.P3---");
string text3 = @"Welcome to the ""Dream World"" ";
Console.WriteLine(text3);
Console.WriteLine(text3.ToUpper());
Console.WriteLine(text3.ToLower());
Console.WriteLine("\n---End of 2.P3---");


Console.WriteLine("\n---2.P4---");
string url = @"https:\\google.com";
Console.WriteLine(url);


//string for= "abc";//error
//string @for = "abc";//ok


Console.WriteLine("\n---End of 2.P4---");


Console.WriteLine("\n---2.P5---");
string text5 = "    This is a sample text. ";
Console.WriteLine($"Original line:'{text5}'");
Console.WriteLine($"Trimmed line:'{text5.Trim()}'");

Console.WriteLine("\n---End of 2.P5---");


Console.WriteLine("\n---2.P6---");
char[] trimChars = { ' ', 't', '.', '*' };
string text6 = " ***This is a sample text.*** ";
Console.WriteLine($"Original line:'{text6}'");
Console.WriteLine($"Trimmed line:'{text6.Trim(trimChars)}'");
Console.WriteLine($"New trimmed line:'{text6.TrimEnd(trimChars)}'");
Console.WriteLine("\n---End of 2.P6---");


Console.WriteLine("\n---2.P7---");
string emptyString = String.Empty;
string? nullString = null;

Console.WriteLine($"The emptyString's length is: {emptyString.Length}");//0
//Console.WriteLine($"The nullString's length is: {nullString.Length}"); //Exception

Console.WriteLine(string.IsNullOrEmpty(emptyString));//True
Console.WriteLine(string.IsNullOrEmpty(nullString));//True

Console.WriteLine("\n---End of 2.P7---");

Console.WriteLine("\n---2.P8---");
string text8 = "Reviewing the concepts of C#.";
string welcome1 = text8.PadLeft(text8.Length + 2, '*');
string welcome2 = welcome1.PadRight(welcome1.Length + 3, '#');
Console.WriteLine($"Original line:'{text8}'");
Console.WriteLine($"Updated line:'{welcome2}'");

Console.WriteLine("\n---End of 2.P8---");

