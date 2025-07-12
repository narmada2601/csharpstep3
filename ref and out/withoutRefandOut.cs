using System;

///<summary>
///here math is a method which takes number  1 and number 2  as parameters......
///this math function returns a value and by adding two numbers........ 
///so when i call the math function i could not prerform multiple tasks  like add,sub,multiply,divide.
///</summary>
namespace withoutrefandout
{
    class withoutRefandOut
    {
        public static void Main()
        {
            int result = Math(10, 20);
            Console.WriteLine("the addition of two numbers are:" + result);//30 -0utput
        }

        public static int Math(int Number1, int Number2)
        {
            return (Number1 + Number2);
        }
    }
}
    
