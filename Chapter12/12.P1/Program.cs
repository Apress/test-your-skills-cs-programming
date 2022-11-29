Console.WriteLine("---12.P1---");
Console.WriteLine("***Experimenting lambda expressions with different parameters.***");

Action del1 = () => Console.WriteLine("Hello");
del1();

Func<int,int> del2 = x => x * x;
Console.WriteLine($"Square of 9 is {del2(9)}");

Action<int,int> del3 = (int x, int y) =>
{
    int sum = x + y;
    Console.WriteLine($"The sum of {x} and {y} is {sum}");
};
del3(10, 20);


