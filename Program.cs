using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BaskaraDepaSaputra
{
   static void Main()
    {
        string[] arrayNama = new string[] { "Joni", "Meri", "david", "Sari" };
        Console.WriteLine("Panjang arrayNama = " + arrayNama.Length);

        for (int i = 0; i <= arrayNama.Length; i++)
        {
            Console.WriteLine("Elemen dengan indeks " + i + " = " + arrayNama[i]);
        }
    }
}