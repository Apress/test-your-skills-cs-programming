Console.WriteLine("\n---2.P14---");
int row = 2, column = 3;
int[,] elements = new int[row, column];
elements[0, 0] = 2;
elements[0, 1] = 5;
elements[0, 2] = -16;
elements[1, 0] = 6;
elements[1, 2] = 19;

Console.WriteLine("The rectangular array is as follows:");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write(elements[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\n---End of 2.P14---");

Console.WriteLine("\n---2.P15 and 2.P16---");
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
jaggedArray[1] = new int[6] { 5, 6, 7, 8, 9, 10 };
jaggedArray[2] = new int[2] { 11, 12 };
Console.WriteLine($"Element at [0][1]={jaggedArray[0][1]}");// 2
Console.WriteLine($"Element at [1][3]={jaggedArray[1][3]}");// 8
Console.WriteLine($"Element at [2][1]={jaggedArray[2][1]}");// 12
Console.WriteLine($"The last element's index of jaggedArray[1] is {jaggedArray[1].GetUpperBound(0)}");// 5
Console.WriteLine($"The first element's index of jaggedArray[2] is {jaggedArray[2].GetLowerBound(0)}");// 0
//Console.WriteLine($" The jaggedArray[2].GetUpperBound(1) is {jaggedArray[2].GetUpperBound(1)}");// Run-time Exception

Console.WriteLine("\n---End of 2.P15 and 2.P16---");

Console.WriteLine("\n---2.P17---");
int[,] rectArray = new int[3, 4];
Console.WriteLine($"The rectArray.Length= {rectArray.Length}");
Console.WriteLine("\n---End of 2.P17---");

Console.WriteLine("\n---2.P18---");
int[][] jaggedArray3 = new int[3][];
jaggedArray3[0] = new int[4] { 1, 2, 3, 4 };
jaggedArray3[1] = new int[5] { 5, 6, 7, 8, 9 };
jaggedArray3[2] = new int[2] { -2, 7 };
Console.WriteLine($"The jaggedArray3.Length= {jaggedArray3.Length}");// 3
Console.WriteLine($"The jaggedArray3[1].Length= {jaggedArray3[1].Length}");// 5
Console.WriteLine("\n---End of 2.P18---");

Console.WriteLine("\n---2.P19---");
double[] rates = new double[4] { 2.2, 3.3, 1.1, 5.5 };
Console.Write("The original array:");
Display(rates);
Array.Sort(rates);
Console.Write("\nThe sorted array:");
Display(rates);
Console.Write("\nThe reversed array:");
Array.Reverse(rates);
Display(rates);
static void Display(Array rates)
{
    foreach (double rate in rates)
    {
        Console.Write(rate + "\t");
    }
}
Console.WriteLine("\n---End of 2.P19---");

Console.WriteLine("\n---2.P20---");
int[] scores = new int[] { 1, 2, 3, 4, 5 };
scores.SetValue(50, 4);
Console.WriteLine($"scores[3]={scores[3]}");
Console.WriteLine($"scores[4]={scores[4]}");

Console.WriteLine("\n---End of 2.P20---");
