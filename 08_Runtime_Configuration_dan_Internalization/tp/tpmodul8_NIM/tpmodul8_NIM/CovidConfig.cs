using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul8_NIM
{
    class CovidConfig
    {
        private const string ConfigFileName = "covid_config.json";

        public string satuan_suhu { get; set; }
        public int batas_hari_deman { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        public CovidConfig()
        {
            // Default values
            satuan_suhu = "celcius";
            batas_hari_deman = 14;
            pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
            pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
        }

        public static CovidConfig LoadConfig()
        {
            if (File.Exists(ConfigFileName))
            {
                string json = File.ReadAllText(ConfigFileName);
                return JsonSerializer.Deserialize<CovidConfig>(json);
            }
            else
            {
                // Create default config
                var defaultConfig = new CovidConfig();
                defaultConfig.SaveConfig();
                return defaultConfig;
            }
        }


        public void SaveConfig()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(ConfigFileName, json);
        }

        public void UbahSatuan()
        {
            if (satuan_suhu == "celcius")
            {
                satuan_suhu = "fahrenheit";
            }
            else
            {
                satuan_suhu = "celcius";
            }

            SaveConfig();
            Console.WriteLine($"Satuan suhu berhasil diubah menjadi {satuan_suhu}");
        }
    }
}
