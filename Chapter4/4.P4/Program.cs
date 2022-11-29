Console.WriteLine("---4.P4---");

Employee emp1 = new();
Employee emp2 = new("Bob");
Employee emp3 = new("Sumit", 2);

Console.WriteLine("Employee Details:");
Console.WriteLine($"Name: {emp1.Name}, Id: {emp1.Id}");
Console.WriteLine($"Name: {emp2.Name}, Id: {emp2.Id}");
Console.WriteLine($"Name: {emp3.Name}, Id: {emp3.Id}");

class Employee
{
    public string Name;
    public int Id;

    public Employee(string name = "Anonymous", int id = 0)
    {
        this.Name = name;
        this.Id = id;
    }
}

