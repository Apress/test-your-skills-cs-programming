Console.WriteLine("\n---1.P19 and 1.P20---");
int i = 5;
//while (i) //CS0029 error
//while ()//CS1525 error
{
    Console.WriteLine($"i is now {i}");
    i++;
}

Console.WriteLine("\n---End of 1.P19 and 1.P20---");

Console.WriteLine("\n---1.P21---");
//int j = 0, m = 0;
////The following code will cause an infinite loop
//while (true)
//{
//    Console.WriteLine($"j is now {j}");
//    m++;
//}
Console.WriteLine("\n---End of 1.P21---");

Console.WriteLine("\n---1.P22---");
int flag = 1;
while (flag != 3)
{
    Console.WriteLine($"flag is now {flag}");
    flag++;
    if (flag == 2)
        goto level_1;
}
flag = 50;
Console.WriteLine($"flag is now {flag}");

level_1:
flag = 100;
Console.WriteLine($"flag is now {flag}");

Console.WriteLine("\n---End of 1.P22---");



Console.WriteLine("\n---1.P23---");
int k = 0;
level_2:
Console.WriteLine($"The current value: {k}");
k++;
if (k < 3) goto level_2;
Console.WriteLine("\n---End of 1.P23---");

Console.WriteLine("\n---1.P24---");
DummyMethod(true);
void DummyMethod(bool b)
{
    b = false;
    //  goto level_3;// ERROR CS0159  
}
level_3:
//Console.WriteLine("Reached to the level_3");

Console.WriteLine("\n---End of 1.P24---");

