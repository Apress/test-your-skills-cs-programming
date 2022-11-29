Console.WriteLine("\n---3.P14---");
Employee emp1 = new Employee();
//Employee emp1 = new ();
emp1.Name = "Jack";
Console.WriteLine($"{emp1.Name} is a {emp1.Occupation()}");
interface IPerson
{
    string Occupation();
}

struct Employee : IPerson
{
    public string Name;
    public string Occupation()
    {
        return "salaried person.";
    }
}
