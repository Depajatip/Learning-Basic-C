using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BaskaraDepaSaputra
{
    static void Main(string[] args)
    {
        PrintMethodVoid();
        Console.WriteLine(PrintMethodReturn());
    }

    static void PrintMethodVoid()
    {
        Console.WriteLine("Ini adalah method void");
    }
    static String PrintMethodReturn()
    {
        return "Ini adalah method return String";
    }
}