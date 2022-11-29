Console.WriteLine("---9.T11---"); 
int a = 100;
unsafe
{
    int* p;
    p = &a;
    Console.WriteLine("Pointer Type Demo.");
    // Console.WriteLine($"p is containing:{&a}");// Error CS0306
    Console.WriteLine($"*p is {*p}");
}


unsafe
{
    // int* b, c; // OK
    //int *b, *c; // ERROR in C#
}