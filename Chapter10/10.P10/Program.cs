Console.WriteLine("---10.P10---");
Prog_10_P10.MyDel1 del1 = Prog_10_P10.Sample.Sum;
//Prog_10_P10.MyDel2 del2 = del1;// ERROR CS0029
// The following is OK
Prog_10_P10.MyDel2 del2 = new Prog_10_P10.MyDel2(del1);
Console.WriteLine(del2(10, 2)); // OK

namespace Prog_10_P10
{
    public delegate int MyDel1(int x, int y);
    public delegate int MyDel2(int x, int y);

    class Sample
    {
        public static int Sum(int a, int b)
        {
            Console.WriteLine("The Sum method is invoked.");
            return a + b;
        }
    }
}

