Console.WriteLine("---7.P16---"); 
Console.WriteLine("***Indexers with multiple parameters.***");
IEmployee emp = new EmployeeStore();
// Picking the employee ID from the name
Console.WriteLine($"Does the employee Sam with ID 1 exist? {emp["Sam", 1]}");
Console.WriteLine($"Does the employee Kate with ID 3 exist? {emp["Kate", 3]}");
Console.WriteLine($"Does the employee Jack with ID 3 exist? {emp["Jack", 3]}");

class Employee
{
    string _name;
    int _id;
    public Employee(string name, int Id)
    {
        this._name = name;
        this._id = Id;
    }

}
interface IEmployee
{
    public bool this[string name, int id] { get; }
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
    public bool this[string name, int id]
    {
        get
        {
            bool temp = false;
            if (name.Equals("Sam") && id == 1) temp = true;
            if (name.Equals("Kate") && id == 2) temp = true;
            if (name.Equals("Jack") && id == 3) temp = true;
            return temp;
        }
        //set
        //{
        //    // Remaining code skipped

        //}
    }
}


