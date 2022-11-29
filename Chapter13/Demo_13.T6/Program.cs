using System.Runtime.InteropServices;
Console.WriteLine("---13.T6---");

class GenericClassDemo2<T>
{
    //[DllImport("Somefile.dll")] // Error CS 7046
    private static extern void SomeMethod();
}

class Sample<T>
{
    static unsafe void ShowMe()
    {
        int a = 10; // ok
        int* p; // ok
        p = &a; // ok

        //T* _flag; // error
    }
}



