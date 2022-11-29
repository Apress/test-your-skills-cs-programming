Console.WriteLine("---10.T2---");
Program_10_T2.MultiDel del = Program_10_T2.Sample.DisplaySum;
del += Program_10_T2.Sample.DisplayDifference;
//del = del+ Program_10_T2.Sample.DisplayDifference; // OK too
del += Program_10_T2.Sample.DisplayProduct;
del(90, 10);

//Console.WriteLine("\nRemoving one method from the delegate.");
//del -= Program_10_T2.Sample.DisplayDifference;
//del(90, 10);

#region Testing Combine and Remove method
//The following code segment also works
Console.WriteLine("\nTesting Combine method.");
Program_10_T2.MultiDel delSum = Program_10_T2.Sample.DisplaySum;
Program_10_T2.MultiDel delDiff = Program_10_T2.Sample.DisplayDifference;
Program_10_T2.MultiDel delProd = Program_10_T2.Sample.DisplayProduct;
Program_10_T2.MultiDel del2 = Delegate.Combine(delSum, delDiff) as Program_10_T2.MultiDel;
Console.WriteLine("\nInvoking del2.");
del2(90, 10);

Program_10_T2.MultiDel del3= Delegate.Combine(del2, delProd) as Program_10_T2.MultiDel;
Console.WriteLine("\nInvoking del3 now.");
del3(90, 10);
Console.WriteLine("\nRemoving one method from the delegate(using Remove method).");
del3 = Delegate.Remove(del3, delProd) as Program_10_T2.MultiDel;
del3(90, 10);
#endregion


namespace Program_10_T2
{
    public delegate void MultiDel(int x, int y);
    class Sample
    {
        public static void DisplaySum(int a, int b) =>
           Console.WriteLine($"Sum={a + b}");

        public static void DisplayDifference(int a, int b) =>
           Console.WriteLine($"Difference={a - b}");

        public static void DisplayProduct(int a, int b) =>
           Console.WriteLine($"Product={a * b}");
    }
}
