Console.WriteLine("\n---3.P20---");
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
