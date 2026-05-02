using Modul9_103022400132;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul9_103022400132
{
    internal class BankTransferConfig
    {
        public Config config;
        public string filepath;

        public BankTransferConfig()
        {
            config = new Config();
            filepath = "@bank_transfer_config.json";

            try
            {
                ReadConfigFile();
            } catch {
                SetDefaultConfig();
                WriteConfigFile();
            }
        }
        public void ReadConfigFile()
        {
            string json = File.ReadAllText(filepath);
            config = JsonSerializer.Deserialize<Config>(json);
        }
        public void WriteConfigFile() 
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            string jsonString = JsonSerializer.Serialize(config);
            options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
        }
        public void SetDefaultConfig()
        {
            config.lang = "en";
            config.transfer = new Transfer(25000000, 6500, 15000);
            config.confirmation = new Confirmation("yes", "ya");
            config.methods = new List<string>() { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
        }
    }
}
