Console.WriteLine("---13.P12---");
// Some code

// Employee StoreHouse
EmployeeStoreHouse<Employee, Person> empStore = new EmployeeStoreHouse<Employee, Person>();


interface IEmployee
{
    // Some code
}
class Employee : IEmployee
{
    //readonly int _id;
    //public Employee(int id)
    //{
    //    _id = id;
    //}    
    // Some other code, if any

}
class Person 
{
    //string _name;
    public Person()
    {
        // some code
    }
    // Some other code, if any

}
class EmployeeStoreHouse<T,U> where T : Employee?, IEmployee?
                              where U: new()                                                  
{
   // Some other code, if any
}