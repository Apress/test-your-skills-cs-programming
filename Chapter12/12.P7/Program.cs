Console.WriteLine("---12.P7---");
var input = Tuple.Create(1, 2.3);
Console.WriteLine("The input tuple is as follows:");
Console.WriteLine("First Element: " + input.Item1);
Console.WriteLine("Second Element: " + input.Item2);

//Sample.DoubleMaker del =
//  (Tuple<int, double> input) => Tuple.Create(input.Item1 * 2, input.Item2 * 2);

Func<Tuple<int, double>, Tuple<int, double>> del =
  (Tuple<int, double> input) => Tuple.Create(input.Item1 * 2, input.Item2 * 2);

var result = del(input);
Console.WriteLine("\nThe resultant tuple is as follows:");
Console.WriteLine("First Element: " + result.Item1);
Console.WriteLine("Second Element: " + result.Item2);

//Console.WriteLine("\nUsing normal method call.");
//result = Sample.MakeDouble(input);
//Console.WriteLine("The resultant tuple is as follows:");
//Console.WriteLine("First Element: " + result.Item1);
//Console.WriteLine("Second Element: " + result.Item2);
//class Sample
//{
//    internal delegate Tuple<int, double> DoubleMaker(Tuple<int, double> input);
//    static internal Tuple<int, double> MakeDouble(Tuple<int, double> input)
//    {
//        return Tuple.Create(input.Item1 * 2, input.Item2 * 2);
//    }
//}
