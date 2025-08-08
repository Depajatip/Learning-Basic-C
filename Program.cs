using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BaskaraDepaSaputra
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("== Simple Calculator ==");
            Console.WriteLine("1. Pertambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("5. Keluar");

            Console.Write("Anda akan masuk ke menu: ");
            string pilihan = Console.ReadLine();

            static int pertambahan(int numberOne, int numberTwo)
            {
                int jawaban = numberOne + numberTwo;
                return jawaban;
            }
            static int pengurangan(int numberOne, int numberTwo)
            {
                int jawaban = numberOne - numberTwo;
                return jawaban;
            }
            static int perkalian(int numberOne, int numberTwo)
            {
                int jawaban = numberOne * numberTwo;
                return jawaban;
            }
            static int pembagian(int numberOne, int numberTwo)
            {
                int jawaban = numberOne / numberTwo;
                return jawaban;
            }


            switch (pilihan)
            {
                case "1":

                    Console.WriteLine("== Anda masuk ke menu Pertambahan");
                    Console.Write("Masukan angka ke 1: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Masukan angka ke 2: ");
                    int num2 = int.Parse(Console.ReadLine());

                    int tambah = pertambahan(num1, num2);

                    Console.WriteLine($"hasil dari pertambahan: {num1} + {num2} adalah: {tambah}");

                    break;

                case "2":

                    Console.WriteLine("== Anda masuk ke menu Pengurangan");
                    Console.Write("Masukan angka ke 1: ");
                    int num1kurang = int.Parse(Console.ReadLine());
                    Console.Write("Masukan angka ke 2: ");
                    int num2kurang = int.Parse(Console.ReadLine());

                    int kurang = pengurangan(num1kurang, num2kurang);

                    Console.WriteLine($"hasil dari pengurangan: {num1kurang} - {num2kurang} adalah: {kurang}");

                    break;
                case "3":

                    Console.WriteLine("== Anda masuk ke menu Perkalian");
                    Console.Write("Masukan angka ke 1: ");
                    int num1kali = int.Parse(Console.ReadLine());
                    Console.Write("Masukan angka ke 2: ");
                    int num2kali = int.Parse(Console.ReadLine());

                    int kali = perkalian(num1kali, num2kali);

                    Console.WriteLine($"hasil dari perkalian: {num1kali} x {num2kali} adalah: {kali}");

                    break;
                case "4":

                    Console.WriteLine("== Anda masuk ke menu Pembagian");
                    Console.Write("Masukan angka ke 1: ");
                    int num1bagi = int.Parse(Console.ReadLine());
                    Console.Write("Masukan angka ke 2: ");
                    int num2bagi = int.Parse(Console.ReadLine());

                    int bagi = pembagian(num1bagi, num2bagi);

                    Console.WriteLine($"hasil dari pembagian: {num1bagi} % {num2bagi} adalah: {bagi}");

                    break;
                case "5":
                    Console.WriteLine("Keluar dari program...");
                    return;

                default:
                    Console.WriteLine("");
                    break;

            }
        }
    }
}