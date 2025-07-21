using System;
using System.Threading.Tasks;

namespace Restaraunt
{
    class Program
    {
        static async Task<string> PrepareFood()
        {
            await Task.Delay(4000);
            return "🍲 Food is ready!";
        }

        static async Task<string> PrepareDrink()
        {
            await Task.Delay(2000);
            return "🥤 Drink is ready!";
        }

        static async Task<string> PrintBill()
        {
            await Task.Delay(1000);
            return "🧾 Bill is printed!";
        }
        static async Task<int> TotalBill()
        {
            await Task.Delay(1000);
            return 2999;
        }
        static async Task Main()
        {
            var starttime = DateTime.Now;
            Console.WriteLine("Customer has arrived at the restaurant.");

            Task<string> foodTask = PrepareFood();
            Task<string> drinkTask = PrepareDrink();
            Task<string> billTask = PrintBill();
            Task<int> totalBill = TotalBill();

            Console.WriteLine("Waiter is working on your order.....");

             string[] result =await Task.WhenAll( drinkTask, foodTask,billTask);
            foreach (string msg in result)
            {
                Console.WriteLine(msg);
            }
            
            Console.WriteLine("Total Bill:" + await totalBill);

            var endtime = DateTime.Now;
            var totaltime = endtime - starttime;
            Console.WriteLine($"Total time taken to complete the preparation is:{totaltime.TotalMilliseconds}");

            Console.WriteLine("Order complete. Enjoy your meal! 🍴");
        }

    }
}