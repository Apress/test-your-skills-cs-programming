Console.WriteLine("---4.P5---");
Employee emp1 = new() { Name = "Bob", Id = 1 };
Employee emp2 = new("Kate") { Id = 3};
Console.WriteLine("Employee Details:");
Console.WriteLine($"Name: {emp1.Name}, Id: {emp1.Id}");
Console.WriteLine($"Name: {emp2.Name}, Id: {emp2.Id}");
class Employee
{
    public string Name;
    public int Id;
    public Employee() { }
    public Employee(string name)
    {
        this.Name = name;
    }

}