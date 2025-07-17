using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpstep3.Extension_Methods
{
    public static class stringExtenstions
    {
        public static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

     class ReverseString
    {
        public static void Main()
        {
            Console.WriteLine("enter a string to reverse");
            string orginal=Console.ReadLine();
            string reverse = orginal.Reverse();//using extension
            Console.WriteLine("Riverse of the string is"+reverse);
        }
    }
}
