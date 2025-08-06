using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BaskaraDepaSaputra
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Menggunakan for loop: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        Console.WriteLine("Menggunakan while loop");
        int j = 1;
        while (j <= 10)
        {
            Console.WriteLine(j);
            j++;
        }
    }
}