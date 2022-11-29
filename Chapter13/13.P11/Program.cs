Console.WriteLine("---13.P11---");
// Some code
class Employee
{
    readonly int _id;
    public Employee(int id)
    {
        _id = id;
    }
    // Some other code, if any

}
class EmployeeStoreHouse<T> where T : class, new() // OK
//class EmployeeStoreHouse<T> where T : class, new(int) // CS0701 with other errors
{
    readonly List<Employee> database = new();
    public void AddToStore(Employee element)
    {
        database.Add(element);
    }
    // Some other code, if any
}
