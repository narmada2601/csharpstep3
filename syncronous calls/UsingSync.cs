using System;
using System.Threading;


namespace csharpstep3.syncronous_calls
{
     class UsingSync
    {
        //we are using thread.sleep
        static void Main()
        {
            Console.WriteLine("im starting");
            Thread.Sleep(2000);
            Console.WriteLine("im paused please wait........");
            Thread.Sleep(1000);
            Console.WriteLine("exit");
        }
        
    }
}
