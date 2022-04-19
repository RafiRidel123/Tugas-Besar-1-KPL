using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Tubes1KPL_Kelompok7
{
    public class Config
    {
        public LaundryConfig conf;
        public string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public string fileConfigName = "laundry_config.json";
        public Config()
        {
            try
            {
                ReadConfigFile();
            }
            catch
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }
        private LaundryConfig ReadConfigFile()
        {
            String jsonString = File.ReadAllText(filePath + @"\" + fileConfigName);
            conf = JsonSerializer.Deserialize<LaundryConfig>(jsonString);
            return conf;
        }

        private void SetDefault()
        {
            harga hargaLaundry = new harga(0.42, 6000);
            List<string> metodeLaundry = new List<string> { "Reguler", "Semi Quick", "Quick", "Express" };
            conf = new LaundryConfig("english", "USD", hargaLaundry, metodeLaundry);
        }

        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(conf, options);
            string fullFilePath = filePath + @"\" + fileConfigName;
            File.WriteAllText(fullFilePath, jsonString);
        }
    }

    public class LaundryConfig
    {
        public string bahasa { get; set; }
        public string mataUang { get; set; }
        public harga hargaLaundry { get; set; }
        public List<string> metodeLaundry { get; set; }
        

        public LaundryConfig() { }

        public LaundryConfig(string bahasa, string mataUang, harga hargaLaundry, List<string> metodeLaundry)
        {
            this.bahasa = bahasa;
            this.mataUang = mataUang;
            this.metodeLaundry = metodeLaundry;
        }
    }
    public class harga
    {
        public double USD { get; set; }
        public double Rupiah { get; set; }

        public harga() { }
        public harga(double USD, double Rupiah)
        {
            this.USD = USD;
            this.Rupiah = Rupiah;
        }

    }

}
