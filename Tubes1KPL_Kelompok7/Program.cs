using System;

namespace Tubes1KPL_Kelompok7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Config Laundry = new Config();
            Console.Write("Language (english/indonesia): ");
            string bahasa = Console.ReadLine();
            int pilihan, berat, i = 0;
            double tagihan;
            if (bahasa == "english")
            {
                Console.Write("Currency (USD/Rupiah): ");
                string mataUang = Console.ReadLine();
                foreach (string metode in Laundry.conf.metodeLaundry)
                {
                    i++;
                    Console.WriteLine(i + ". " + metode);
                }
                Console.Write("Select laundry method: ");
                pilihan = int.Parse(Console.ReadLine());
                Console.Write("Laundry weight (kg): ");
                berat = int.Parse(Console.ReadLine());
                tagihan = berat * Laundry.conf.hargaLaundry.USD;
                if (mataUang == "USD")
                {
                    tagihan = berat * Laundry.conf.hargaLaundry.USD;
                    Console.WriteLine("Payment Bill: $" + tagihan);
                } else if (mataUang == "Rupiah")
                {
                    tagihan = berat * Laundry.conf.hargaLaundry.Rupiah;
                    Console.WriteLine("Payment Bill: Rp " + tagihan);
                }
            }
            else if (bahasa == "indonesia")
            {
                Console.Write("Mata Uang (USD/Rupiah): ");
                string mataUang = Console.ReadLine();
                foreach (string metode in Laundry.conf.metodeLaundry)
                {
                    i++;
                    Console.WriteLine(i + ". " + metode);
                }
                Console.Write("Pilih metode laundry: ");
                pilihan = int.Parse(Console.ReadLine());
                Console.Write("Berat laundry (kg): ");
                berat = int.Parse(Console.ReadLine());
                if (mataUang == "USD")
                {
                    tagihan = berat * Laundry.conf.hargaLaundry.USD;
                    Console.WriteLine("Tagihan pembayaran: $" + tagihan);
                }
                else if (mataUang == "Rupiah")
                {
                    tagihan = berat * Laundry.conf.hargaLaundry.Rupiah;
                    Console.WriteLine("Tagihan pembayaran: Rp " + tagihan);
                }
            }
        }
    }
}