Console.WriteLine("---9.T1---");
int i = 1;

object o = i; // Boxing
// object o=i; // It is OK, because since boxing is implicit.

//int j = o; // ERROR CS0266
int j = (int)o; // Unboxing

double d = i;


