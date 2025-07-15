using System;
using System.Threading.Tasks;

    class understandaync
    {
    public static async Task Main()
    {
        await SayHelloAsync();
        await SayGoodbyeAsync();

    }
    static async Task SayHelloAsync()
    {
        await Task.Delay(1000); // Simulate delay
        Console.WriteLine("Hello, Aravind!");
    }

    static async Task SayGoodbyeAsync()
    {
        await Task.Delay(1000); // Simulate delay
        Console.WriteLine("Goodbye, Aravind!");
    }

}

