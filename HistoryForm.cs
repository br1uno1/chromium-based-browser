using System;
using System.IO;
using System.Windows.Forms;

namespace CustomBrowser
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            LoadHistory();
        }

        private void LoadHistory()
        {
            if (File.Exists("AppData/history.txt"))
            {
                listBoxHistory.Items.AddRange(File.ReadAllLines("AppData/history.txt"));
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            File.Delete("AppData/history.txt");
            listBoxHistory.Items.Clear();
        }
    }
}
