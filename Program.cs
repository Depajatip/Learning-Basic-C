using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BaskaraDepaSaputra
{
    public static void Main(string[] args)
    {
        int? umur;
        Console.Write("Masukan Umur Anda: ");
        umur = int.Parse(Console.ReadLine());

        if (umur > 0 && umur <= 5)
        {
            Console.WriteLine("Balita");
        }
        else if (umur > 6 && umur <= 12)
        {
            Console.WriteLine("Anak - Anak");
        }
        else if (umur > 13 && umur <= 17)
        {
            Console.WriteLine("Remaja");
        }
        else if (umur > 18 && umur <= 59)
        {
            Console.WriteLine("Dewasa");
        }
        else
        {
            Console.WriteLine("Lansia");
        }
        
    }
}