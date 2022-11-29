Console.WriteLine("---10.P5---");

Action multiDel = Program_10_P5.Sample.Show1;
multiDel += Program_10_P5.Sample.Show2;
multiDel += Program_10_P5.Sample.Show3;
multiDel();
namespace Program_10_P5
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
