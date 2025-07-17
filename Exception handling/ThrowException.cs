using System;

class ThrowException
{
    public static void Main()
    {
        try
        {
            ThrowExceptions();//call a method that throws an exception
        }
        catch (Exception ex)
        {
            // Handle the exception from the method
            Console.WriteLine("Caught an exception in Main: " + ex.Message);
        }
        finally
        {
            // This block always runs
            Console.WriteLine("Execution of the try-catch block is complete.");
        }
    }
    static void ThrowExceptions()
    {
        try
        {
            // Manually throw an exception
            throw new Exception("An error occurred in the try block.");
        }
        catch (Exception ex)
        {
            // Handle the exception
            Console.WriteLine("Caught an exception in ThrowException: " + ex.Message);
            throw; // Rethrow the exception for further handling
        }
        finally
        {
            // This block always runs
            Console.WriteLine("Execution of the ThrowException method is complete.");
        }
    }
}

