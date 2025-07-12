using System;
using System.Collections.Generic;
 class UsingBoth1
    {
    public static void empInfo(out int id, out string firstname,out string lastname)
    {
        id = 1;
        firstname = " Narmada";
        lastname= null;
    }
    public static void Main()
    {
        int id;
        string str1, str2;
        empInfo(out id, out str1, out  str2);
        Console.WriteLine(id + " " + str1 + " " + str2);
    }
    }

