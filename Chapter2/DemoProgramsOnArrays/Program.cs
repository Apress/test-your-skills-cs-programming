Console.WriteLine("\n---2.T8---");
//int[] numbers = new int[3];
//numbers[0] = 5;
//numbers[1] = 12;
//numbers[2] = 7;


//// Alternative approach-2.
//int[] numbers = new int[] { 5, 12,7 };



//// Alternative approach-3.
//int[] numbers = { 5, 12, 7 };


// Alternative approach-4.
// For an explicit instantiation, var is also allowed
var numbers = new int[] { 5, 12, 7 };

// For an explicit instantiation, var is also allowed


Console.WriteLine("Iterating over the array elements:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(numbers[i]);
}
Console.WriteLine("Iterating over the array elements:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

Console.WriteLine("\n---End of 2.T8---");

Console.WriteLine("\n---2.T10---");

//int[,] rectArray = {
//  {10, 20,30},
//  {30, 40,60},
//  };
int row = 2, column = 3;
int[,] rectArray = new int[row, column];
rectArray[0, 0] = 10;
rectArray[0, 1] = 20;
rectArray[0, 2] = 30;
rectArray[1, 0] = 40;
rectArray[1, 1] = 50;
rectArray[1, 2] = 60;

Console.WriteLine("The rectangular array is as follows:");
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(rectArray[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\n---End of 2.T10---");

Console.WriteLine("\n---2.T11---");
int[][] jaggedArray = {
  new int[] {0,1},
  new int[] {2,3,4},
};
//int[][] jaggedArray = new int[2][];// Contains two 1D array
//jaggedArray[0] = new int[2];// First row has 2 elements
//jaggedArray[1] = new int[3];// Second row has 3 elements

//// Initializing the first row
//jaggedArray[0][1] = 0;
//jaggedArray[0][1] = 1;

//// Initializing the second row
//jaggedArray[1][0] = 2;
//jaggedArray[1][1] = 3;
//jaggedArray[1][2] = 4;

Console.WriteLine("The jagged array is as follows:");
for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\n---End of 2.T11---");

Console.WriteLine("\n---2.T12---");
// Using the foreach loop to print the elements in the jagged array
Console.WriteLine("The jagged array is as follows:");
foreach (int[] rows in jaggedArray)
{
    foreach (int i in rows)
    {
        Console.Write(i + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\n---End of 2.T12---");


