Console.WriteLine("---13.P2---");
List<int> myList = new();
myList.Add(10);
myList.Add(20);
// Cannot convert from 'string' to 'int'
//myList.Add("InvalidElement");//Compile-time error
Console.WriteLine(" The list elements are:");
foreach (int myInt in myList)
{
    Console.WriteLine((int)myInt);//downcasting
}

