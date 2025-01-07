namespace CustomBrowser
{
    partial class SettingsForm
    {
        private System.Windows.Forms.Label lblSearchEngine;
        private System.Windows.Forms.TextBox txtSearchEngine;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox comboTheme;
        private System.Windows.Forms.Button btnSave;

        private void InitializeComponent()
        {
            this.lblSearchEngine = new System.Windows.Forms.Label();
            this.txtSearchEngine = new System.Windows.Forms.TextBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.comboTheme = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();

            // Label Search Engine
            this.lblSearchEngine.Text = "Motor de búsqueda predeterminado:";
            this.lblSearchEngine.Location = new System.Drawing.Point(20, 20);
            this.lblSearchEngine.Size = new System.Drawing.Size(250, 20);

            // TextBox Search Engine
            this.txtSearchEngine.Location = new System.Drawing.Point(20, 50);
            this.txtSearchEngine.Size = new System.Drawing.Size(300, 22);

            // Label Theme
            this.lblTheme.Text = "Tema:";
            this.lblTheme.Location = new System.Drawing.Point(20, 90);
            this.lblTheme.Size = new System.Drawing.Size(100, 20);

            // ComboBox Theme
            this.comboTheme.Items.AddRange(new string[] { "light", "dark" });
            this.comboTheme.Location = new System.Drawing.Point(20, 120);
            this.comboTheme.Size = new System.Drawing.Size(150, 24);

            // Button Save
            this.btnSave.Text = "Guardar";
            this.btnSave.Location = new System.Drawing.Point(20, 160);
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // SettingsForm
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.lblSearchEngine);
            this.Controls.Add(this.txtSearchEngine);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.comboTheme);
            this.Controls.Add(this.btnSave);
            this.Name = "SettingsForm";
            this.Text = "Configuraciones";
        }
    }
}
