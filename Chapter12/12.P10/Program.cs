Console.WriteLine("---12.P10---");
//Sample sample = new();
//sample.del(97, 3);


// More Experiment(NOT Shown in the book)
//Console.WriteLine($"\nx is now {Sample.x}"); // 97
//Console.WriteLine($" y is now {Sample.y}"); // 3

//Sample.del1(Sample.x, Sample.y);
//Console.WriteLine($"\nx is now {Sample.x}"); // 98
//Console.WriteLine($" y is now {Sample.y}"); // 4


class Sample
{
    //public static int x = 97, y = 3;
    //static internal Action<int, int> del1 = static (x1, y1) =>
    //    Console.Write(x++ + y++); // Here we do not work on local variable, instead we work on instance variables

    internal Action<int, int> del = static (x, y) =>
                                     Console.Write(x + y);
}



