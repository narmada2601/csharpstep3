using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;


public class WashingMachine
{
    public string Name { get; set; }
    public string Mode { get; set; }

    public WashingMachine( string name,string mode)
    {
       Name = name;
        Mode= mode;
    }
}
public static class WashingMachineExtensions
{
    public static async Task FillWaterAsync(this WashingMachine machine)
    {
       
        Console.WriteLine($"{machine.Name}: Filling water...");
        
    }
    public static async Task WashAsync(this WashingMachine machine)
    {
        
        await Task.Delay(2000);
        Console.WriteLine($" clothes Washing started.");
    }
    public static async Task DrainAsync(this WashingMachine machine)
    {
       
        await Task.Delay(3000);
        Console.WriteLine($"water drained completed.");
    }
    public static async Task RinseAsync(this WashingMachine machine)
    {
        
        await Task.Delay(2000);
        Console.WriteLine($" water Rinsed completed.");
    }
    public static async Task SpinDryAsync(this WashingMachine machine)
    {
        
        await Task.Delay(5000);
        Console.WriteLine($" water spin dry completed.");
    }

    
    public static async Task RunFullCycleAsync( this WashingMachine machine)
        
    {
        switch (machine.Mode.ToUpper())
        {
            case "QUICK":
                await machine.FillWaterAsync();
                await machine.WashAsync();
                await machine.SpinDryAsync();
                break;

            case "NORMAL":
                await machine.FillWaterAsync();
                await machine.WashAsync();
                await machine.DrainAsync();
                await machine.RinseAsync();
                await machine.DrainAsync();
                await machine.SpinDryAsync();
                break;

            case "TURBO":
                await machine.FillWaterAsync();
                await machine.WashAsync();
                
                await machine.DrainAsync();
                await machine.RinseAsync();
                await machine.DrainAsync();
                await machine.SpinDryAsync();
                break;

            case "STRONG":
                await machine.FillWaterAsync();
                Console.WriteLine($"{machine.Name}: Gentle washing...");
                await Task.Delay(1500);
                await machine.DrainAsync();
                await machine.SpinDryAsync();
                break;

            default:
                Console.WriteLine("❌ Invalid mode selected.");
                break;
        }
        Console.WriteLine($"✅ {machine.Name}: {machine.Mode} cycle complete.");

       

    }
}
class AsyncExample
    {
        static async Task Main()
        {
       
        Console.WriteLine("My washing machine application using async and extension methods");
        Console.WriteLine("Enter wash mode (QUICK,NORMAL,strong,Turbo)");
        string mode = Console.ReadLine();
        var startTime = DateTime.Now;
        await Task.Delay(5000); // 5 sec delay
       WashingMachine machine = new WashingMachine("...Lg TopLoad ... ", mode);
       
        await machine.RunFullCycleAsync();
        var endTime = DateTime.Now;
        Console.WriteLine($"Water filled in {(startTime - endTime).TotalSeconds}seconds");
    }
}

