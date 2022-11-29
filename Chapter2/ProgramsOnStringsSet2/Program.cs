using System.Runtime.Serialization;//For the ObjectIDGenerator uses
using System.Text;//For the StringBuilder uses

Console.WriteLine("\n---2.P9---");
Console.WriteLine("Enter the string:");
string? inputStr = Console.ReadLine();
string? reverseStr = ReverseString(inputStr);
Validate(inputStr, reverseStr);

// Reversing a string
static string ReverseString(string str)
{
    char[] tempArray = str.ToCharArray();
    // Reverses the sequence of the elements
    Array.Reverse(tempArray);
    // Change the reversed array to a string
    string reverseStr = new(tempArray);
    // Return this string
    return reverseStr;
}

// Check for the palindrome string

static void Validate(string str1, string str2)
{
    if (str1.Equals(str2))
    {
        Console.WriteLine($"The string: '{str1}' is a palindrome string.");
    }
    else
    {
        Console.WriteLine($"The string '{str1}' is a not palindrome string.");
    }

}

Console.WriteLine("\n---End of 2.P9---");

Console.WriteLine("\n---2.P10---");
Console.WriteLine("***String vs StringBuilder.***");
ObjectIDGenerator idGenerator = new();
bool firstTime = false;

Console.WriteLine("\nWorking with a String instance.");
string text = "Hello";
Console.WriteLine($"The instance id of {text} is {idGenerator.GetId(text, out firstTime)}");
// Creates a new instance ID
text += ",John!";
Console.WriteLine($"The instance id of {text} is {idGenerator.GetId(text, out firstTime)}");

Console.WriteLine("\nWorking with a StringBuilder instance.");
StringBuilder text2 = new("Hello, John!");
Console.WriteLine($"The instance id of {text2} is {idGenerator.GetId(text2, out firstTime)}");
// The following does not create a new instance ID
text2 = text2.Replace("Hello", "Welcome");
Console.WriteLine($"The instance id of {text2} is {idGenerator.GetId(text2, out firstTime)}");
Console.WriteLine("\n---End of 2.P10---");

Console.WriteLine("\n---2.P11---");
string strInput = "12";
Console.WriteLine(strInput + 5);
int intInput = int.Parse(strInput);
Console.WriteLine(intInput + 5);

Console.WriteLine("\n---End of 2.P11---");

Console.WriteLine("\n---2.P12---");

if (int.TryParse("123", out int input2))
{
    Console.WriteLine("Successfully parsed the string.");
    Console.WriteLine($"The result is: {input2 + 5}");
}
else
{
    Console.WriteLine("Couldn't parse the given string.");
}

Console.WriteLine("\n---End of 2.P12---");

Console.WriteLine("\n---2.P13---");
string hello = "Welcome reader!";
int firstIndex = hello.IndexOf('e');
int secondIndex = hello.IndexOf('e', firstIndex + 1);
int thirdIndex = hello.IndexOf('e', secondIndex + 1);
Console.WriteLine($"The given string: {hello}");
Console.WriteLine($"The 1st index of 'e' is at location:{firstIndex}");
Console.WriteLine($"The 2nd index of 'e' is at location:{secondIndex}");
Console.WriteLine($"The 3rd index of 'e' is at location:{thirdIndex}");

Console.WriteLine("\n---End of 2.P13---");
