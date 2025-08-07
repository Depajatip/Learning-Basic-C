using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BaskaraDepaSaputra
{
    static void Main()
    {
        Console.Write("Masukan Panjang array nama = ");
        int panjangArray = int.Parse(Console.ReadLine());
        string[] arrayNama = new string[panjangArray];
        for (int i = 0; i < panjangArray; i++)
        {
            Console.Write("Masukan nama ke-" + i + " = ");
            arrayNama[i] = Console.ReadLine();
        }
        Console.WriteLine("--Menampilkan semua elemen array--");
        for (int i = 0; i < arrayNama.Length; i++)
        {
            Console.WriteLine("Elemen dengan indeks " + i + " = " + arrayNama[i]);
        }
    }
}