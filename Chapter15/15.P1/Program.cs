Console.WriteLine("---15.P1---");
string language = "C#";
string version = "11";
string message = $"""
    Hello reader! How are you?
      {language} {version} is about to be released.
     Raw string literals are available in version: {version} 
    """;
Console.WriteLine(message);




//string message2 = $$"""
//   You are using {{{language}}: {{version}}}  // You are using {C#: 11}
//   """;

//Console.WriteLine(message2);
