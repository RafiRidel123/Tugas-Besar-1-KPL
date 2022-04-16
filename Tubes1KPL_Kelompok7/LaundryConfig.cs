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
            conf = new LaundryConfig("english", "Dolar");
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

        public LaundryConfig() { }

        public LaundryConfig(string bahasa, string mataUang)
        {
            this.bahasa = bahasa;
            this.mataUang = mataUang;
        }
    }

}
