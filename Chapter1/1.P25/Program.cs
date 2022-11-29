Console.WriteLine("---1.P25---");
Console.WriteLine("***Illustration: break vs continue ***");
int i = 1;
while (i != 5)
{
    Console.WriteLine($"Now, i= {i}");
    i++;
    if (i == 4)
    {
        Console.WriteLine(" Entered inside if loop");
        //break;
        continue;
    }
}

