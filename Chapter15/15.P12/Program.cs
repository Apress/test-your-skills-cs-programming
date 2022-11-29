Console.WriteLine("---9.P12---");
namespace Container1
{
    //public class Sample
    public partial class Sample
    {
        // Errors: CS8795 and CS 0751
        //internal partial void SayHello();

        //partial void SayHello();// Error:CS0751 if the class is not partial
        partial void SayHello(); // No error

    }
}


