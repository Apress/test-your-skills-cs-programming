//Console.WriteLine("---12.P14---");

//MyDelegate del = (int x, y) => (x > y) ? "Yes." : "No."; // ERROR CS0748

// Func<int, int, string> del = (x, int y) => (x > y) ? "Yes." : "No."; // ERROR CS0748
//Func<int, int, string> del = (int x, int y) => (x > y) ? "Yes." : "No."; // OK
Func<int, int, string> del = (x, y) => (x > y) ? "Yes." : "No."; // OK

string result=del(10, 7);
Console.WriteLine(result);

//string result2 = del(2,3);
//Console.WriteLine(result2);//OUTput  : No

delegate string MyDelegate(int a, int b);
