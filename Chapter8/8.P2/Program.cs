Console.WriteLine("***Case study with multiple catch blocks.***");
try
{
    Console.WriteLine("Enter an integer:");
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
    Console.WriteLine($"You have entered the number: {number}");
}
catch (FormatException ex)
{
    Console.WriteLine("You need to enter an integer.");
    Console.WriteLine($"The exception detail: {ex.StackTrace}");
}
catch (OverflowException ex)
{
    Console.WriteLine(" You need to provide smaller number.");
    Console.WriteLine($"The exception detail: {ex.StackTrace}");
}

catch (Exception ex)
{
    Console.WriteLine($"Encountered an unknown error.");
    Console.WriteLine($"The exception detail: {ex.StackTrace}");
}
finally
{
    Console.WriteLine("Thank you for testing this scenario.");
}

