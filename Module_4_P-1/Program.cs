internal class Program
{
    private static void Main(string[] args)
    {
        //getting input from the user via the console
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {
            //converting the string data to 32bit integer
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);

            //dividing the numbers with static int method a display the result in the console
            int result = Divide(number1, number2);
            Console.WriteLine($"the result of {number1} divided by {number2} is {result}");
        }
        catch (FormatException ex)
        {
            //catching the formatting error if either or both of the inputs are not a good integer
            Console.WriteLine("Error: One or both inputs are not a valid integer.");
            Console.WriteLine($"Details: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            //can not divide by zero
            Console.WriteLine("Error: Dividing by zero is not possible.");
            Console.WriteLine($"Details: {ex.Message}");
        }
        catch (OverflowException ex)
        {
            //catching over flow error if either or both of the inputs are not a good integer
            Console.WriteLine("Error: One or both inputs larger that 32bits.");
            Console.WriteLine($"Details: {ex.Message}");
        }
        catch (Exception ex)
        {
            //catching any other errors that might happen
            Console.WriteLine("OOPPSS!! Something else went wrong.");
            Console.WriteLine($"Details: {ex.Message}");
        }
        //cleanly exit the program
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
    // static int method to divide two integers
    static int Divide(int a, int b)
    {
        // just return a/b
        return a/b;
    }
}
