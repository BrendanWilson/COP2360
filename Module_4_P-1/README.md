# Module 4: P-1 Handling Division and Conversion Exceptions [Individual Project]

## Handling Division and Conversion Exceptions
## Objective:
Learn how to use `try-catch` blocks to handle exceptions that may occur during division operations and string-to-integer conversions.

## Instructions:
1. Create a new C# Console Application.
2. Implement a method that takes two strings as input, converts them to integers, and performs division.
3. Use `try-catch` blocks to handle potential exceptions such as `FormatException` and `DivideByZeroException`.
4. Print appropriate error messages for each exception.
5. If no exceptions occur, print the result of the division.

## Explanation:

1. User Input: The program prompts the user to enter two numbers.
2. Conversion and Division:
    * The Convert.ToInt32 method is used to convert the input strings to integers.
    * The Divide method performs the division.
3. Exception Handling:
    * `FormatException`: Caught when the input string is not in a valid format to be converted to an integer.
    * `DivideByZeroException`: Caught when attempting to divide by zero.
    * `Exception`: Catches any other unexpected exceptions.

## Steps for Students:

1. un the program and test with various inputs to see how exceptions are handled.
2. Modify the code to handle additional exceptions, such as `OverflowException` for numbers that are too large.
3. Add more detailed error messages or logging to understand how exceptions can provide useful debugging information.
4. Experiment by removing the `try-catch` blocks to see how unhandled exceptions terminate the program.