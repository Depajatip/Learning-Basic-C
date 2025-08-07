using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BaskaraDepaSaputra
{
    static void Main()
    {
        string[] arrayRplSatu = new string[5];
        string[] arrayRplDua = new string[5];
        Console.WriteLine("\n=== Input Nama Siswa RPL 1 ===");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Masukkan nama siswa RPL 1 ke-{i + 1}: ");
            arrayRplSatu[i] = Console.ReadLine();
        }
        Console.WriteLine("\n=== Input Nama Siswa RPL 2 ===");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Masukkan nama siswa RPL 2 ke-{i + 1}: ");
            arrayRplDua[i] = Console.ReadLine();
        }
        Console.WriteLine("\n=== Input Nama Siswa RPL 1 ===");
        for (int i = 0; i < arrayRplSatu.Length; i++)
        {
            Console.WriteLine($"Siswa RPL 1 ke-{i + 1}: {arrayRplSatu[i]}");
        }
        Console.WriteLine("\n=== Input Nama Siswa RPL 2 ===");
        for (int i = 0; i < arrayRplDua.Length; i++)
        {
            Console.WriteLine($"Siswa RPL 2 ke-{i + 1}: {arrayRplDua[i]}");
        }
    }
}