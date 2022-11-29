Console.WriteLine("---13.P10---");
// Employees
Employee e1 = new();
Employee e2 = new();

// Employee StoreHouse
EmployeeStoreHouse<Employee> empStore = new();
empStore.AddToStore(e1);
empStore.AddToStore(e2);
class Employee
{
    public Employee() { }
    // Some other code, if any

}
class EmployeeStoreHouse<T> where T : Employee, new() // OK
//class EmployeeStoreHouse<T> where T : class, new() // Also OK
//class EmployeeStoreHouse<T> where T : new(), class // error
//class EmployeeStoreHouse<T> where T : new(), Employee // Error
{
    readonly List<Employee> database = new();
    public void AddToStore(Employee element)
    {
        database.Add(element);
    }
    // Some other code, if any
}

