using System;

class LoginSystem
{
    static void Main()
    {
        Console.Write("Enter User ID (numeric): ");
        string userIdInput = Console.ReadLine();

        if (!int.TryParse(userIdInput, out int userId))
        {
            Console.WriteLine("Invalid User ID. It must be a number.");
            return;
        }

        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(username))
        {
            Console.WriteLine("Username cannot be empty.");
            return;
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            Console.WriteLine("Password cannot be empty.");
            return;
        }

        //  credentials
        int expectedId = 1;
        string expectedUsername = "narmada";
        string expectedPassword = "narmada123";

        if (userId == expectedId && username == expectedUsername && password == expectedPassword)
        {
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Invalid credentials.");
        }
    }
}
