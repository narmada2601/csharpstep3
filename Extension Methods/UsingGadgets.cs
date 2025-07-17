using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpstep3.Extension_Methods
{
    public class Gadget
    {
        public string Name { get; set; }
        public int BatteryLevel { get; set; }
    }
    //create an extension method
    public static class GadgetExtension
    {
        public static bool needsCharging(this Gadget gadget)
        {
            return gadget.BatteryLevel < 15;
        }
        public static string GetStatus(this Gadget gadget,string Brand)
        {
            return $"{gadget.Name} has {gadget.BatteryLevel}% battery.";
        }

    }
    class UsingGadgets
    {
        public static void Main()
        {
            Gadget gadget = new Gadget()
            {
                Name = "SmartWatch",
                BatteryLevel = 10
            };
            Console.WriteLine("gadget charging info"+gadget.needsCharging());
            Console.WriteLine ("gadget status "+gadget.GetStatus("Apple"));
        }
    }
}
