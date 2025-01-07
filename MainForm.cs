using System;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace CustomBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            var newTab = new TabPage("Nueva pestaña");
            var browser = new ChromiumWebBrowser("https://www.google.com")
            {
                Dock = DockStyle.Fill
            };
            browser.TitleChanged += (s, args) => Invoke((MethodInvoker)(() => newTab.Text = args.Title));
            tabControl.TabPages.Add(newTab);
            tabControl.SelectedTab = newTab;
            newTab.Controls.Add(browser);
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count > 0)
            {
                tabControl.TabPages.Remove(tabControl.SelectedTab);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
    }
}
