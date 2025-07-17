using System;


//static class for extending the calculator operations
//class must be static 
public static class CalculatorOperations
{
    //extension methods
    public static int Square(this Calculator calc, int number)
    {
        return number * number;
    }
}

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
    
}

        class CalculatorExtensions
    {
         static void Main()
        {
        //create instance of calculator
        Calculator calculate = new Calculator();
            //USE EXTENSION METHOD 
            Console.WriteLine("addition" + calculate.Add(2, 14));
            Console.WriteLine("subtraction" + calculate.subtract(10, 4));
            Console.WriteLine("Multiplication: " + calculate.Multiply(10, 5));
            //  new extension method Square
            Console.WriteLine("enter the number to get the square");
           string  input= Console.ReadLine();
        int number;

        if (int.TryParse(input, out number))
        {
            Console.WriteLine("Square of " + number + ": " + calculate.Square(number));
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }


        Console.ReadKey();
        }
    }

