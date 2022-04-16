using System;

namespace Tubes1KPL_Kelompok7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Config Laundry = new Config();
            Console.WriteLine("Language: ");
            string bahasa = Console.ReadLine();
            if (bahasa == "english" || bahasa == "en")
            {
                Console.WriteLine("Currency: ");
                string mataUang = Console.ReadLine();
            }
            else if (bahasa == "indonesia" || bahasa == "id")
            {
                Console.WriteLine("Mata Uang: ");
                string mataUang = Console.ReadLine();
            }
        }
    }
}