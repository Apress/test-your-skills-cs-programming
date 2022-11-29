Console.WriteLine("---13.P18---");
Console.WriteLine("Self-referencing generic type demo.");
Employee emp1 = new Employee("Physics", 1);
Employee emp2 = new Employee("Mathematics", 2);
Employee emp3 = new Employee("Computer Science", 1);
Employee emp4 = new Employee("Mathematics", 2);
Employee emp5 = null;
Console.WriteLine($"Comparing emp1 and emp3: {emp1.CompareWith(emp3)}");
Console.WriteLine($"Comparing emp2 and emp4: { emp2.CompareWith(emp4)}");
Console.WriteLine($"Comparing emp2 and emp5: {emp2.CompareWith(emp5)}");

interface IIdenticalEmployee<T>
{
    string CompareWith(T obj);
}
class Employee : IIdenticalEmployee<Employee>
{
    string _name;
    int _id;
    public Employee(string name, int id)
    {
        _name = name;
        _id = id;
    }
    public string CompareWith(Employee obj)
    {
        if (obj == null)
        {
            return "Cannot compare with a null object.";
        }
        else
        {
            if (_name == obj._name && _id == obj._id)
            {
                return "Identical Employees.";
            }
            else
            {
                return "Different Employees.";
            }
        }
    }
}

