using System;

using System.Threading.Tasks;

namespace csharpstep3.Asyncronous_Calls
{
    class TaskDelay
    {
        //aysync we are using
        //take static class
        static async Task Method1()
        {
            Console.WriteLine("I am printing");
            await Task.Delay(2000);
            Console.WriteLine("method1 gets delay here");
        }
        static async Task Method2()
        {
            Console.WriteLine("I am printing");
            await Task.Delay(3000);
            Console.WriteLine("method2 gets  delay here");
        }
        //main method
        static async Task Main()
        {


            //await Taskdelay.Method1();//static method so we call directly
            //Console.WriteLine("method1 ends");
            ////calling method 2
            //await taskdelay.method2();//static method so we call directly
            //console.writeline("method2 ends");

            // //we can also use
             Task task1 = TaskDelay.Method1();//i am printing
            task1.Wait();
            Task task2 = TaskDelay.Method2();
            task2.Wait();
            await Method1();
            await Method2();

        }
    }
}
