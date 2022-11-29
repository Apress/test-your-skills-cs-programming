Console.WriteLine("---13.P6---");
interface IColor<T> { }
interface IBrand<T, U> { }

// Segment 1:
class Car1<T> : IColor<T> { }
// Segment 2:
//class Car2<T> : IBrand<T, U> { } // ERROR CS0246
// Segment 3:
class Car3<T> : IBrand<T, string> { }
// Segment 4:
//class Car4<U> : IBrand<T, int> { } // ERROR CS0246
// Segment 5:
class Car5<T> : IBrand<string, int> { }
// Segment 6:
class Car6 : IColor<string> { }
// Segment 7:
class Car7 : IBrand<double,string> { }
