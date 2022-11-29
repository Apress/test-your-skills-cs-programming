using System.Collections;

Console.WriteLine("---13.T3---");
/*
List<int> myList = new();
myList.Add(10);
myList.Add(20);
//myList.Add("InvalidElement");
Console.WriteLine(" The list elements are:");
foreach (int myInt in myList)
{
    Console.WriteLine((int)myInt);
}
*/


// Using ArrayList. It is NOT recommended here.
ArrayList myList2 = new();
myList2.Add(10);
myList2.Add(20);
// No compile time error, but runtime error will occur
myList2.Add("InvalidElement");
foreach (int myInt in myList2)
{
     // Will encounter run-time exception for the
     // final element  which is not an int
    Console.WriteLine((int)myInt);
}

