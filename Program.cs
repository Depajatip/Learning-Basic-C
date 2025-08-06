using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BaskaraDepaSaputra
{
    public static void Main(string[] args)
    {
        int? angka;
        Console.Write("Masukan Angka Bulat: ");
        angka = int.Parse(Console.ReadLine());

        if (angka % 2 == 0)
        {
            Console.WriteLine($"Angka {angka} adalah bilangan Genap");
        }
        else
        {
            Console.WriteLine($"Angka {angka} adalah bilangan Ganjil");
        }
    }
}