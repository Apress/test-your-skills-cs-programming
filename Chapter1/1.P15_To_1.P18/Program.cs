Console.WriteLine("---1.P15---");
Console.WriteLine("Using a while loop:");
int i = 0;
while (i < 3)
{
    Console.WriteLine($"The current value: {i}");
    i++;
}
Console.WriteLine("\nUsing an equivalent for loop:");
for (int j = 0; j < 3; j++)
{
    Console.WriteLine($"The current value: {j}");
}

Console.WriteLine("\n---End of 1.P15---");

Console.WriteLine("\n---1.P16 and 1.P17---");
//for (int k1 = 0; ; k1++)  // Causes infinite loop
//{
//    Console.WriteLine($"The current value: {k1}");
//}

//for (int k2 = 0; k2 < 3;)  // Causes infinite loop
//{
//    Console.WriteLine($"The current value: {k2}");
//}

Console.WriteLine("\n---End of 1.P6 and 1.P17---");


Console.WriteLine("\n---1.P18---");
for (int k = 0; k < 8; k += 3)
{
    Console.WriteLine($"The current value: {k}");
}

Console.WriteLine("\n---End of 1.P18---");
