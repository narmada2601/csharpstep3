using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml.Serialization;
/// <summary>
/// syncronous calls:executes one after the other.
/// When a request is made to a synchronous API, the server processes the request and waits
/// for it to be completed before moving on to the next task. This means that if one operation 
/// takes a long time to finish, it can block the execution of subsequent operations,
/// potentially leading to slower response times for clients.
/// </summary>
/// 

///waits till one task finishes
class cookingusingsync
{
    public static void Main()
    {
        Stopwatch sw = new Stopwatch();
        //start the stopwatch
        sw.Start();
        CookMealSync();
        sw.Stop();
        // Get the elapsed time in seconds
        TimeSpan elapsed = sw.Elapsed;

        Console.WriteLine($"Elapsed Time (Seconds): {elapsed.TotalSeconds} s");//14 seconds
        Console.ReadLine();
    }
    public static void CookMealSync()
    {
        Console.WriteLine("Cooking meal...");

        CutVegetablesSynchronously();
        BoilWaterSynchronously();
        CompleteOtherCookingSynchronously();
    }
    private static void BoilWaterSynchronously()
    {
        Console.WriteLine("Boiling water...");
        Task.Delay(3000).Wait(); // Simulating a synchronous task
        Console.WriteLine("Water is boiling!");
    }

    private static void CutVegetablesSynchronously()
    {
        Console.WriteLine("Chopping vegetables...");
        Task.Delay(3000).Wait(); // Simulating a synchronous task
        Console.WriteLine("Vegetables are ready!");
    }

    private static void CompleteOtherCookingSynchronously()
    {
        Console.WriteLine("Adding Seasonings...");
        Console.WriteLine("Tasting for salt...");
        Console.WriteLine("Cooking for 8 seconds");

        Task.Delay(8000).Wait();
        Console.WriteLine("Done cooking!");
    }
}


