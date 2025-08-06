using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BaskaraDepaSaputra
{
    public static void Main(string[] args)
    {
        Console.WriteLine("program belajar for loop");

        Console.Write("masukan batas angka: ");
        int batasAtas = int.Parse(Console.ReadLine());

        Console.WriteLine("Angka dari 1 hingga: " + batasAtas + ":");
        for (int i = 1; i <= batasAtas; i++)
        {
            Console.WriteLine(i + " ");
        }
        Console.Write("\nselesai.");
    }
}