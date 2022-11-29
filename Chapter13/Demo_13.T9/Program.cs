Console.WriteLine("---13.T9---");
Dictionary<int, string> employees = new();
employees.Add(1, "Sam");
employees.Add(2, "Bob");
employees.Add(3, "Kate");
Console.WriteLine("The dictionary elements are:");
foreach( KeyValuePair<int,string> element in employees)
{
    Console.WriteLine($"ID: {element.Key} Name: {element.Value}");
}


