Console.WriteLine("---12.P5---");
List<int> numbers = new() { 12, 23, 37, 45, 52 };
Console.WriteLine("The list contains the following numbers:");
foreach (int number in numbers)
{
    Console.Write(number+"\t");
}
Console.WriteLine("\nFinding the numbers which are greater than 30");
#region Using method call syntax 
// Using method call syntax
Console.WriteLine("\nUsing the method call syntax:");
IEnumerable<int> numbersAbove30 = numbers.Where(x => x > 30);
foreach (int number in numbersAbove30)
{
    Console.WriteLine(number);
}
#endregion
#region Using the query syntax
var query = from num in numbers
                  where num > 30
                  select num;
Console.WriteLine("Using the query syntax now.");
foreach (int number in query)
{
    Console.WriteLine(number);
}
#endregion


