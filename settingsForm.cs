using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CustomBrowser
{
    public partial class SettingsForm : Form
    {
        private string settingsPath = "AppData/browser_settings.json";

        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            if (File.Exists(settingsPath))
            {
                var settings = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(settingsPath));
                txtSearchEngine.Text = settings.default_search_engine;
                comboTheme.SelectedItem = settings.theme;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var settings = new
            {
                default_search_engine = txtSearchEngine.Text,
                theme = comboTheme.SelectedItem.ToString()
            };
            File.WriteAllText(settingsPath, JsonConvert.SerializeObject(settings, Formatting.Indented));
        }
    }
}
