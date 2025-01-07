namespace CustomBrowser
{
    partial class HistoryForm
    {
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Button btnClearHistory;

        private void InitializeComponent()
        {
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.btnClearHistory = new System.Windows.Forms.Button();

            // ListBox
            this.listBoxHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxHistory.Size = new System.Drawing.Size(400, 200);

            // Button Clear History
            this.btnClearHistory.Text = "Limpiar Historial";
            this.btnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);

            // HistoryForm
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.btnClearHistory);
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Name = "HistoryForm";
            this.Text = "Historial";
        }
    }
}
