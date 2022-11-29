Console.WriteLine("---7.P15---"); 
Console.WriteLine("Case studies with the interfaces.");
IEmployee emp = new EmployeeStore();

// Picking the employee name from the ID
Console.WriteLine($"The name of emp[0] is {emp[0]}");
Console.WriteLine($"The name of emp[1] is {emp[1]}");
Console.WriteLine($"The name of emp[2] is {emp[2]}");
//Console.WriteLine($"Name of emp[3] is {emp[3]}");// System.IndexOutOfRangeException

Console.WriteLine("**************");

// Picking the employee ID from the name
Console.WriteLine($"The ID of Sam is {emp["Sam"]}");
Console.WriteLine($"The ID of Kate is {emp["Kate"]}");
Console.WriteLine($"The ID of Jack is {emp["Jack"]}");


class Employee
{
    string _name;
    int _id;
    public Employee(string name, int Id)
    {
        this._name = name;
        this._id = Id;
    }

    public int EmployeeId
    {
        get => _id;
    }
    public string Name
    {
        get => _name;
    }

}
interface IEmployee
{
    public string this[int id] { get; }
    public int this[string name] { get; }
}
class EmployeeStore : IEmployee
{
    Employee[] employees;
    public EmployeeStore()
    {
        employees = new Employee[] {

            new Employee("Sam", 1),
            new Employee("Kate", 2),
            new Employee("Jack", 3),

        };
    }
    public string this[int id]
    {
        get => employees[id].Name;

    }
    public int this[string name]
    {
        get
        {
            int temp = 0;
            if (name.Equals("Sam")) temp = employees[0].EmployeeId;
            if (name.Equals("Kate")) temp = employees[1].EmployeeId;
            if (name.Equals("Jack")) temp = employees[2].EmployeeId;
            return temp;
        }
    }
}


