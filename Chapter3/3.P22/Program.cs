// Console.WriteLine("\n---3.P22---");
Employee emp1 = new Employee("Sam", 1);
Console.WriteLine(emp1);

Employee emp2 = emp1 with { Id = 2 };
Console.WriteLine(emp2);


Employee emp3 = emp2 with { Name = "Kate", Id = 2 };
Console.WriteLine(emp3);

//Employee emp4 = emp3 with { Name = "Jacklin", Id = 3 };
//Console.WriteLine(emp4);

struct Employee
{
    public string Name;
    public int Id;
    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public override string ToString()
    {
        string emp = Name + " has ID " + Id;
        return emp;
    }
}
