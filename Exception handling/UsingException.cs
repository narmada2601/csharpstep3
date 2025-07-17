using System;
///<summary>Exception:it is an error that ocuurs during the execution of a program
///exceptions handled by try,catch,finally blocks
/// try-code that throw exception
/// catch-handle the exception
/// finally-code that always execute whether exception throw or not
/// throw-used for manually throw the exception
/// 
/// 
/// </summary>
namespace csharpstep3.Exception_handling
{

    
    class UsingException
    {
        public static void Main()
        {
            //array of 4 indexes
            //int[] arr = { 1, 2, 3, 4, 5 };
            //display array values
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);//print 1,2,3,4,5
            //}
            //Console.WriteLine(arr[7]);//indexout of range exception

            
            try
            {
                //code that throws the exception
                string input = "abc";
                int number = int.Parse(input); // This will throw FormatException
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]);
                Console.WriteLine("........................");
                string name = null;
                Console.WriteLine(name);
              
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error: Invalid format. Cannot convert string to integer.");
                Console.WriteLine("Exception Message: " + e.Message);
            }
            catch (Exception e)
            {
                // This will catch any other types of exceptions
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine("Exception Message: " + e.Message);
            }
            finally
            {
                // This block always runs, regardless of whether an exception occurred
                Console.WriteLine("Execution of the try-catch block is complete.");
            }

        }
    }
}
