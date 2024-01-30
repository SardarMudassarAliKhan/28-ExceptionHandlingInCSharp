using System;

class Program
{
    static void Main()
    {
        try
        {
            // Simulating a division operation that might throw an exception
            int numerator = 10;
            int denominator = 0;
            int result = Divide(numerator, denominator);
            Console.WriteLine($"Result of division: {result}");
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine($"Error: Cannot divide by zero. Details: {ex.Message}");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            // Cleanup or finalization code (if any)
            Console.WriteLine("Program execution completed.");
        }
    }

    static int Divide(int numerator, int denominator)
    {
        // Simulating a division operation that might throw an exception
        if(denominator == 0)
        {
            throw new DivideByZeroException("Denominator cannot be zero.");
        }

        return numerator / denominator;
    }
}
