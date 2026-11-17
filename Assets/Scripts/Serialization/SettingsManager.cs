using System.IO;
using UnityEngine;

namespace Settings
{
    public class SettingsManager : MonoBehaviour
    {
        public static SettingsManager Instance { get; private set; }

        public static GlobalSettings Settings => Instance == null ? null : Instance._settings;

        private GlobalSettings _settings;

        private string SettingsPath =>
            Path.Combine(Application.persistentDataPath, "settings.json");

        private void Awake()
        {
            // Singleton
            if (Instance == null)
                Instance = this;


            LoadSettings();
        }

        public void LoadSettings()
        {
            _settings = new GlobalSettings();

            Debug.Log("Searching for settings files in " + SettingsPath);
            if (File.Exists(SettingsPath))
            {
                string json = File.ReadAllText(SettingsPath);

                // Overwrite existing defaults with saved values.
                JsonUtility.FromJsonOverwrite(json, _settings);

                Debug.Log("Settings loaded successfully.");
            }
            else
            {
                Debug.Log("No settings file found. Using default settings.");
                SaveSettings();
            }
        }

        public void SaveSettings()
        {
            string json = JsonUtility.ToJson(_settings, true);
            File.WriteAllText(SettingsPath, json);
        }
    }
}
