Console.WriteLine("---5.T5---"); 
B obB = new B();
A obA = new A();

// This is the proof that 'a' is also inherited.
// See the error message.
//Console.WriteLine(obB._flag1); // 'A._flag1' is inaccessible due to its protection level
//Console.WriteLine(obB._flag2); // 'B' does not contain a definition for '_flag2' etc.
//Console.WriteLine(obA._flag2); // 'A' does not contain a definition for '_flag2' etc.
class A
{
  //  private int _flag1;
}
class B : A
{
}




