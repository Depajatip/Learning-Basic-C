using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BaskaraDepaSaputra
{
    public static void Main(string[] args)
    {
        Console.Write("Masukkan batas maksimal bilangan: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int N))
        {
            Console.WriteLine($"Bilangan genap dari 1 sampai {N} adalah:");
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("Input tidak valid. Harap masukkan bilangan bulat.");
        }
    }
}