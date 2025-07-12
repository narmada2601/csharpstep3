using System;
/// <summary>
/// use in userinput dynamically
/// loops until the input is valid
/// </summary>
 class usingTryParse
    {
    public static void Main()
    {
        //string to int
        string s1 = "12";
       
        if(int.TryParse(s1,out int result))
        {
            Console.WriteLine($"Success! Parsed value: {result}");
        }
        else
        {
            Console.WriteLine("Invalid integer input.");
        }
        //convert string to date time
        string dateInput = "11-07-2025";
        if (DateTime.TryParse(dateInput, out DateTime date))
        {
            Console.WriteLine($"Booking ticket: {date.ToShortDateString()}");
        }
        else
        {
            Console.WriteLine("Invalid date format.");
        }

    }

}
