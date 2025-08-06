using System;

public class DepaaBaskaraSaputra
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Selamat datang di toko kami!!");
        Console.WriteLine("=======================");
        Console.Write("Masukan Nama anda: ");
        string? nama = Console.ReadLine();
        Console.Write("Masukan Umur anda: ");
        string? umur = Console.ReadLine();
        Console.Write("Masukan Alamat anda: ");
        string? alamat = Console.ReadLine();

        Console.WriteLine("=======================");
        Console.WriteLine("List produk di toko kami:");
        Console.WriteLine("a. semen");
        Console.WriteLine("b. paku");
        Console.WriteLine("c. kayu");
        Console.WriteLine("d. asbes");
        Console.WriteLine("e. besi");

        Console.Write("Pilih barang yang akan anda order (pisahkan dengan koma): ");
        string? input = Console.ReadLine();
        string[] orders = input.Split(',');
        string deskripsiOrder = "";
        int diskon = 5000;
        int totalHarga = 0;

        foreach (string item in orders)
        {
            switch (item.Trim().ToLower())
            {
                case "a":
                    deskripsiOrder += "- Semen: Rp 10.000\n";
                    totalHarga += 10000;
                    break;
                case "b":
                    deskripsiOrder += "- Paku: Rp 5.000\n";
                    totalHarga += 5000;
                    break;
                case "c":
                    deskripsiOrder += "- Kayu: Rp 50.000\n";
                    totalHarga += 50000;
                    break;
                case "d":
                    deskripsiOrder += "- Asbes: Rp 20.000\n";
                    totalHarga += 20000;
                    break;
                case "e":
                    deskripsiOrder += "- Besi: Rp 70.000\n";
                    totalHarga += 70000;
                    break;
                default:
                    deskripsiOrder += $"- Item '{item}' tidak dikenali\n";
                    break;
            }
        }

        Console.WriteLine("=======================");
        Console.WriteLine("Terimakasih Sudah belanja di toko kami!!, Ini struk belanja anda:");
        Console.WriteLine($"\nPengorder:  {nama}");
        Console.WriteLine($"Umur: {umur}");
        Console.WriteLine($"Alamat Anda: {alamat}");
        Console.WriteLine("\nBarang yang dibeli: \n" + deskripsiOrder);
        Console.WriteLine("Anda akan mendapat diskon jika belanja lebih dari Rp 10.000");

        baskara(totalHarga, diskon);

        Console.WriteLine("=======================");
    }

    public static void baskara(int totalHarga, int diskon)
    {
        if (totalHarga >= 10000)
        {
            int afterDiskon = totalHarga - diskon;
            Console.WriteLine($"\nSelamat!! Anda mendapat diskon sebesar Rp 5.000");
            Console.WriteLine($"Harga sebelum diskon: Rp {totalHarga:N0}");
            Console.WriteLine($"Harga setelah diskon: Rp {afterDiskon:N0}");

            Console.Write("Masukkan jumlah uang Anda: ");
            string? inputUang = Console.ReadLine();

            if (int.TryParse(inputUang, out int jumlahUang))
            {
                if (jumlahUang >= afterDiskon)
                {
                    int kembalian = jumlahUang - afterDiskon;
                    Console.WriteLine($"Uang Anda: Rp {jumlahUang:N0}");
                    Console.WriteLine($"Kembalian Anda: Rp {kembalian:N0}");
                }
                else
                {
                    Console.WriteLine($"Uang Anda tidak cukup. Total yang harus dibayar: Rp {afterDiskon:N0}");
                }
            }
            else
            {
                Console.WriteLine("Input jumlah uang tidak valid.");
            }
        }
        else
        {
            Console.WriteLine($"Anda tidak mendapat diskon. Harga total: Rp {totalHarga:N0}");
        }
    }
}
