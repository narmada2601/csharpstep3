using System;

namespace csharpstep3.Extension_Methods
{
    public static class Check
    {
        public  static bool checkNumber(this int value)
        {
            return value%2==0;
        }
    }
     class EvenorOdd
    {
        public static void Main()
        {
            Console.WriteLine("enter a number");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                string result = number.checkNumber() ? "Even" : "Odd";
                Console.WriteLine($"The number {number} is {result}.");
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }


        }
    }
}
