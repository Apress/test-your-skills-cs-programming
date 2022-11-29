Console.WriteLine("---9.P4---");
class Rectangle
{
    //#region Correct code segment:1 

    //readonly static int _flag = 20;
    //public static void DisplayFlag()
    //{
    //    Console.WriteLine($"Flag1 is{_flag}");
    //}
    //#endregion

    #region Correct code segment:2
    readonly int _flag = 20;
    public void DisplayFlag()
    {
        Console.WriteLine($"Flag1 is{_flag}");
    }
    #endregion

    //#region Incorrect code segment
    //readonly int _flag = 20;
    //public static void DisplayFlag()
    //{
    //    Console.WriteLine($"Flag1 is{_flag}");
    //}
    //#endregion


}