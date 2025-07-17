using System;
//to calculate the birth year
class CalculateAge
{
    public static void Main()
    {
        Console.WriteLine("enter the date of birth year");
        int birthYear = int.Parse(Console.ReadLine());

        int age = birthYear.Calculate_age();
        Console.WriteLine($"Your age is: {age} years");


    }
}
public static class  calculate
{
    //extension
    public static int Calculate_age(this int  birthYear)
    {
        return DateTime.Now.Year - birthYear;


    }
}

