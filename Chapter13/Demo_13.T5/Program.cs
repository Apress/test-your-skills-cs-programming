Console.WriteLine("---13.T5---");
interface ISample<T>
{
    // Some code
}
class Implementor1<U, T1> : ISample<T1> // Valid
{
    //remaining code
}

class Implementor2<T2, U> : ISample<T2> // Also valid
{
    // Some code
}
