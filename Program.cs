using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BaskaraDepaSaputra
{
    static void Main(string[] args)
    {
        Console.Write("Panjang : ");
        int panjang = Convert.ToInt32(Console.ReadLine());
        Console.Write("Lebar : ");
        int lebar = Convert.ToInt32(Console.ReadLine());

        int luasPersegiPanjang = hitungLuasPersegiPanjang(panjang, lebar);
        Console.WriteLine("Luas Persegi Panjang : " + luasPersegiPanjang);
    }

    static int hitungLuasPersegiPanjang(int panjang, int lebar)
    {
        return panjang * lebar;
    }
}