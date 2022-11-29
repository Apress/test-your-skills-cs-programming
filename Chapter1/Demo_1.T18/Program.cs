Console.WriteLine("\n---1.T18---");
// List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
// // Simplified form:
List<int> list = new() { 1, 2, 3, 4, 5 };
Console.WriteLine("Executing the 'foreach' loop:");
foreach (int index in list)
{
    Console.WriteLine("\t" + index);
}
Console.WriteLine("Executing the 'for' loop :");
for (int index = 0; index < list.Count; index++)
{
    Console.WriteLine("\t" + list[index]);
}


Console.WriteLine("\n---End of 1.T18---");

