using System;
/// <summary>
/// .......................USING REF..................
/// return multiple output from a function.
/// The REF keywords in C# is  used for passing the arguments to a method as a reference type.
/// By default, arguments are passed to a method by value.
/// </summary>

class UsingRef
{
    public static void Main()
    {
        //declare the variables
        int addition =0;
        int subtraction = 0;
        int multiplication = 0;
        int division = 0;
        Math(20, 10, ref addition, ref subtraction, ref multiplication, ref division);
        Console.WriteLine("the addition is" + addition);
        Console.WriteLine("the subtraction is" + subtraction);
        Console.WriteLine("the multiplication is" + multiplication);
        Console.WriteLine("the division is" + division);
        Console.ReadLine();


    }
    //Here, we are passing the parameter are value types. That means int, float, Boolean, etc. are used to create value-type variables
    public static void Math(int Number1, int Number2, ref int addition, ref int subtraction, ref int multiplication, ref int division)
    {
       
        //updating the values 
            addition = Number1 + Number2;
            subtraction = Number1 - Number2;
            multiplication = Number1 * Number2;
            division = Number1 / Number2;

    }
}

