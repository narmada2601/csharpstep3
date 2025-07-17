

using System;

///<summary>Extension Method
///1.extension Method must be defined as static class
///2.Method Itself must be static
///3.The first parameter of the method specifies
///            which type the extension method is extending.
/// 4.The parameter must be preceded by this keyword
///</summary>
public static class simpleExample
{
    //extension method to count words in a string
    //wordcount is a static
    public static int WordCount(this string str)
    {
        //The this string str parameter
        //specifies that the method extends the string type.
        if (string.IsNullOrWhiteSpace(str))
        {
            return 0;
        }
        else
        {
            return str.Split(' ').Length;
        }
    }
}
public class ExtensionProgram
{
    public static void Main()
    {
       Console.WriteLine("enter a string to count no of words ");

        string sentence = Console.ReadLine();
        int count = sentence.WordCount();//using extension method
        Console.WriteLine("word count:"+count);
    }
}
    

