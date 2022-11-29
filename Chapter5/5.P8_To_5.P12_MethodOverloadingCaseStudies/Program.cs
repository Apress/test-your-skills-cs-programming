Console.WriteLine("Different case studies of method overloading in C#.");
/*
Console.WriteLine("---5.P8---");
Sample sample = new Sample();
Console.WriteLine(sample.Add(2, 3));
Console.WriteLine(sample.Add("Mike", "Proctor"));
class Sample
{
    //public int Add(int x, int y)
    //{
    //    return x + y;
    //}
    public int Add(int x, int y) => x + y;


    //public string Add(string s1, string s2)
    //{
    //    return string.Concat(s1,",",s2);
    //}
    public string Add(string s1, string s2) => string.Concat(s1, ",", s2);
}
*/


/*
Console.WriteLine("---5.P9---");
class Sample
{
    public int Sum(int x, int y)
    {
        return x + y;
    }
    //public double Sum(int x, int y) // ERROR CS0111
    //{
    //    return x + y;
    //}
}
*/
/*
Console.WriteLine("---5.P10---");

Employee employee = new Employee();
Employee employee2 = new Employee("Jim", 2);
Employee employee3 = new Employee(3);
class Employee
{
    public Employee() =>
        Console.WriteLine("Employee name: Unknown, ID: Not given");

    public Employee(int id) =>
        Console.WriteLine($"Employee name: Unknown, ID: {id}");

    public Employee(string name, int id) =>
        Console.WriteLine($"Employee name: {name}, ID: {id}");

}
*/

/*
Console.WriteLine("---5.P11---");
Console.WriteLine("Overloading the Main() method.");
Main(5);
static void Main(int a)
{
    Console.WriteLine("I am inside Main(int a) now.");
}
*/

/*

Console.WriteLine("---5.P12---");
Console.WriteLine("Overloading the Main() method.");
Main();
static void Main() => Console.WriteLine("I am inside Main() now.");

*/








