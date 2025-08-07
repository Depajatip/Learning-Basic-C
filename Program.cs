using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BaskaraDepaSaputra
{
    public static void Main(string[] args)
    {
       Console.Write("Masukan Nilai N: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int N))
        {
            int total = 0;
            Console.WriteLine("Bilangan n anda adalah " + N);
            Console.Write("Hasil Penjumlahan 1 sampai " + N + " adalah ");

            for (int i = 1; i <= N; i++)
            {
                total += i;
            }

            Console.WriteLine("= " + total);
        }
        else
        {
            Console.WriteLine("Input tidak valid. Harap masukkan bilangan bulat.");
        }
    }
}