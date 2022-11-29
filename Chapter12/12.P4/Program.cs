Console.WriteLine("---12.P4---");
//Console.WriteLine("***Experimenting lambda expressions with expression-bodied properties.***");
Employee emp = new(1);
//Error.Company is read-only
//empOb.Company = "ABC Co.";
emp.Name = "Kevin Turner ";//ok
Console.WriteLine($"{emp.Name} works in the {emp.Company} as an employee.");
Console.WriteLine($"His ID is {emp.Id}.");
Console.ReadKey();

class Employee
{
    readonly int empId = 0;
    readonly string company = "XYZ company";
    string name = string.Empty;

    // Usual implementation of a constructor.
    //public Employee(int id)
    //{
    //    empId = id;
    //}
    // Following shows an expression-bodied constructor
    public Employee(int id) => empId = id;// OK 


    // Usual implementation of a read-only property
    //public string Company
    //{
    //    get
    //    {
    //        return company;
    //    }
    //}
    // Read-only property.C#6.0 onwards, it is supported.
    public string Company => company;

    // Usual implementation
    //public string Name
    //{
    //    get
    //    {
    //        return name;
    //    }
    //    set
    //    {
    //        name = value;
    //    }
    //}

    // C#7.0 onwards, you can use expression-body definition
    // for the get and set accessors
    public string Name
    {
        get => name;
        set => name = value;
    }

    // Get the employee ID
    public int Id
    {
        get => empId;
    }
}
