Console.WriteLine("---5.P4---");
// Console.WriteLine("Testing another usage of base keyword.");
//Employee emp = new Employee();
Employee emp = new();
emp.DisplayInfo();
class Person
{
    protected string ssn = "123-45-6789";
    protected string name = "K. Peterson";
    protected void GetInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"SSN: {ssn}");
    }
}
class Employee : Person
{
    private string id;
    //public Employee()
    //{
    //    id = "E001";
    //}
    public Employee() => id = "E001";

    public void DisplayInfo()
    {
        //Console.WriteLine("Here is the details:");
        //GetInfo();
        base.GetInfo();
        Console.WriteLine($"ID: {id}");
    }

    //private void GetInfo()
    //{
    //    Console.WriteLine("Child class GetInfo()");
    //}

}
