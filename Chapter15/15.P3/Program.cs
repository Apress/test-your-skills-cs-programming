Console.WriteLine("---15.P3---");
// Works in Visual Studio 2022 version 17.3, not in 17.2.1 also

struct Employee
{
    public string Name;
    public int Id;
    public Employee(string name, int id)
    {
        Name = name;
    }
    public override string ToString()
    {
        string emp = Name + " has ID " + Id;
        return emp;
    }
}

