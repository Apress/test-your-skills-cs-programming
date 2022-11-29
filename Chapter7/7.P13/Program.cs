Console.WriteLine("---7.P13---"); 
Console.WriteLine("Case studies with the interfaces.");

IEmployee emp = new Employee("Sam", 1);
Console.WriteLine($"Name: {emp.Name}, ID:{emp.Id}");
interface IEmployee
{
    public string Name { get; set; }
    public int Id { get; set; }
}
class Employee : IEmployee
{
    string _name;
    int _id;
    public Employee(string name, int Id)
    {
        this._name = name;
        this._id = Id;
    }
    public string Name
    {
        get => _name;
        set => _name = value;        
    }
    public int Id
    {
        get => _id;
        set => _id = value;        
    }
}
