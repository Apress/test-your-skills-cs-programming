Console.WriteLine("---1.P5---");
byte flag1 = 1;
byte flag2 = 2;
//byte flag3 = flag1 + flag2;// ERROR CS0266
//Console.WriteLine($"The flag3 is: {flag3}");
byte flag3 = (byte)(flag1 + flag2); //Ok
Console.WriteLine($"The flag3 is: {flag3}");
Console.WriteLine("\n---End of 1.P5---");
