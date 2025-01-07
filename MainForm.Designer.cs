namespace CustomBrowser
{
    partial class MainForm
    {
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnNewTab;
        private System.Windows.Forms.Button btnCloseTab;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnSettings;

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.btnNewTab = new System.Windows.Forms.Button();
            this.btnCloseTab = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();

            // TabControl
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 40);
            this.tabControl.Size = new System.Drawing.Size(800, 460);

            // Button New Tab
            this.btnNewTab.Text = "Nueva Pestaña";
            this.btnNewTab.Location = new System.Drawing.Point(10, 10);
            this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);

            // Button Close Tab
            this.btnCloseTab.Text = "Cerrar Pestaña";
            this.btnCloseTab.Location = new System.Drawing.Point(120, 10);
            this.btnCloseTab.Click += new System.EventHandler(this.btnCloseTab_Click);

            // Button History
            this.btnHistory.Text = "Historial";
            this.btnHistory.Location = new System.Drawing.Point(230, 10);
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);

            // Button Settings
            this.btnSettings.Text = "Configuraciones";
            this.btnSettings.Location = new System.Drawing.Point(320, 10);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);

            // MainForm
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnNewTab);
            this.Controls.Add(this.btnCloseTab);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnSettings);
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "Custom Browser";
        }
    }
}
