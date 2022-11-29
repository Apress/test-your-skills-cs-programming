Console.WriteLine("---13.P9---");
// Employees
Employee e1 = new("Suresh", 1.5);
Employee e2 = new("Kate", 5.2);
Employee e3 = new("John", 7);

// Employee StoreHouse
EmployeeStoreHouse<Employee> empStore = new(); 
empStore.AddToStore(e1);
empStore.AddToStore(e2);
empStore.AddToStore(e3);

// Display the Employee Positions in Store
//empStore.DisplayStore();

interface IEmployee
{

}
class Employee
{
    string _name;
    double _yearOfExp;
    public Employee() { }
    public Employee(string name, double exp)
    {
        _name = name;
        _yearOfExp = exp;
    }
    public override string ToString()
    {
        return $"Name:{_name} Exp:{_yearOfExp}";
    }

}

class EmployeeStoreHouse<T> where T : new() // ERROR CS0310, in the absense of the public constructor
{
    readonly List<Employee> database = new();
    public void AddToStore(Employee element)
    {
        database.Add(element);
    }
    //public void DisplayStore()
    //{
    //    Console.WriteLine("The currrent database:");
    //    foreach (Employee emp in database)
    //    {
    //        Console.WriteLine(emp.ToString());
    //    }
    //}
}
