Console.WriteLine("---10.P4---");

Program_10_P4.MultiDel multiDel = Program_10_P4.Sample.Show1;
multiDel += Program_10_P4.Sample.Show2;
multiDel += Program_10_P4.Sample.Show3;
multiDel();
namespace Program_10_P4
{
    public delegate void MultiDel();

    class Sample
    {
        public static void Show1()
        {
            Console.WriteLine("Show1() is called.");
        }
        public static void Show2()
        {
            Console.WriteLine("Show2() is called.");
        }
        public static void Show3()
        {
            Console.WriteLine("Show3() is called.");
        }

    }
}



