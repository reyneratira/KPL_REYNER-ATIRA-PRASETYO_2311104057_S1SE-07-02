using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_2311104057
{
    class BankTransferConfig
    {
        private const string ConfigFileName = "bank_transfer_config.json";

        public string lang { get; set; } = "en";
        public Transfer transfer { get; set; } = new Transfer();
        public List<string> methods { get; set; } = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
        public Confirmation confirmation { get; set; } = new Confirmation();

        // load config from file
        public static BankTransferConfig LoadConfig()
        {
            if (File.Exists(ConfigFileName))
            {
                string json = File.ReadAllText(ConfigFileName);
                return JsonSerializer.Deserialize<BankTransferConfig>(json)!;
            }
            else
            {
                var defaultConfig = new BankTransferConfig();
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
    }

    public class Transfer
    {
        public int threshold { get; set; } = 25000000;
        public int low_fee { get; set; } = 6500;
        public int high_fee { get; set; } = 15000;
    }

    public class Confirmation
    {
        public string en { get; set; } = "yes";
        public string id { get; set; } = "ya";
    }
}
