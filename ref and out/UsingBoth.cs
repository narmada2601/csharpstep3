using System;
///<summary> using both
/// as we know  the both outputs are same,but the difference is
/// 1.updating the ref and out variables inside a method
//   -->if you comment line no 36 :its throws a compile time error
//
//2. Initializing the Ref and Out variables while passing to the Method
//in line no 21,if you wont intitialize it throws a comile time errro because
//the value inside the method is optional in ref.in case of out it is optional to intilaize
//as the value is passed inside the out parameter
//both ref and out treated same at compile time but different at rumtime
///</summary>

//example
//public void value(out int i){}
//public void value(ref int i){}overloaded

//overloading
// public void value(int i) {  }
//public void value(out int i) {  }



namespace csharpstep3.ref_and_out
{
    class UsingBoth
    {
        public static void Main()
        {
            //calling the methods with ref
            int addref = 0;
            int subref = 0;//wont initilase throws  compile timeerror
            MathRef(30, 20, ref addref, ref subref);
            Console.WriteLine($"addition using ref{addref}");
            Console.WriteLine($"subtraction using ref{subref}");

            //calling methods using out
            int addout = 0;
            int subout = 0;
            MathOut(30, 20, out addref, out subref);
            Console.WriteLine($"addition using out {addref}");
            Console.WriteLine($"subtraction using out{subref}");
        }
        public static void MathRef(int num1, int num2, ref int addref, ref int subref)
        {
            addref = num1 + num2;
           // subref = num2 - num2;//it is optional

        }
        public static void MathOut(int num1, int num2, out int addout, out int subout)
        {
            addout = num1 + num2;
            subout = num2 - num2;//if you are declaring the out variables,then needs to intialise or update the out variables inside a method body else throw compile time error

        }

    }
}
