using Agenda.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Agenda.LocalAppSettings
{
    public class LocalApplicationSettings
    {
        public List<string> ChosableTime { get; set; } = new List<string>();
        public List<string> TypesOfMassages { get; set; } = new List<string>();
        public List<string> Length { get; set; } = new List<string>();
        public string DbPath { get; set; }

        public LocalApplicationSettings(List<string> chosableTime = null, List<string> typesOfMassages = null, List<string> length = null, string dbPath = null)
        {
            ChosableTime = chosableTime ?? new List<string>(new[] { "Error" });
            TypesOfMassages = typesOfMassages ?? new List<string>(new[] { "Error" });
            Length = length ?? new List<string>(new[] { "Error" });
            DbPath = dbPath ?? "Error";
        }
    }

    public class AccessSettings
    {
        public async static Task SaveSettings(LocalApplicationSettings settings)
        {
            string filePath = Properties.Settings.Default.SettingsPath;
            string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            await Task.Run(() => File.WriteAllText(filePath, json));
        }

        public async static Task<LocalApplicationSettings> LoadSettings()
        {
            Debug.WriteLine("Getting the settings");
            Debug.WriteLine(Settings.Default.SettingsPath);
            Debug.WriteLine(Settings.Default.dbPath);
            string filePath = Properties.Settings.Default.SettingsPath;
            try
            {
                string json = await Task.Run(() => File.ReadAllText(filePath));
                return JsonSerializer.Deserialize<LocalApplicationSettings>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading settings: {ex.Message}");
            }
            return new LocalApplicationSettings(chosableTime: new List<string>(new[] { "Error" }));
        }
    }
}
