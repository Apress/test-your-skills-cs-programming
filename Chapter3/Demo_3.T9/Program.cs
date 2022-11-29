Console.WriteLine("---3.T9---");

Employee emp1 = new(1, "Sam");
Console.WriteLine($"Name: {emp1.Name}, ID:{emp1.Id}");

Employee emp2 = new();
emp2.Name = "Jack";
emp2.Id = 2;
Console.WriteLine($"Name: {emp2.Name}, ID:{emp2.Id}");


Employee emp3;
emp3.Name = "Kate";
emp3.Id = 3;
Console.WriteLine($"Name: {emp3.Name}, ID:{emp3.Id}");

struct Employee
{
    public int Id;
    public string Name;
    public Employee(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
}

