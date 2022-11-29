Console.WriteLine("---4.P8---");
//Sample.NestedSample nested = new();// ERROR CS0122, the class is inaccessible now.
class Sample
{
    class NestedSample
    {
        public NestedSample()
        {
            Console.WriteLine("NestedSample is initialized.");
        }
    }
}
