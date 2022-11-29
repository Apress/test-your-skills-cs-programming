Console.WriteLine("---6.T7---");
abstract class Test
{
    int _flag = 1; // OK
}

interface IParent1 { }
abstract class Parent2 { }
interface IChild1 : IParent1 { } // Ok
abstract class Child2 : Parent2, IParent1 { } // Ok
//interface IChild3 : Parent2 { } // ERROR CS0527
