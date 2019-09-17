namespace Maestre
{
    partial class Home
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.bambini_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.indietro_button = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Bambini_page = new System.Windows.Forms.TabPage();
            this.Libri_page = new System.Windows.Forms.TabPage();
            this.Statistiche_page = new System.Windows.Forms.TabPage();
            this.DelStat = new System.Windows.Forms.Button();
            this.StatLibri = new System.Windows.Forms.Button();
            this.StatBambini = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.Bambini_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // bambini_button
            // 
            this.bambini_button.FlatAppearance.BorderSize = 0;
            this.bambini_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bambini_button.Location = new System.Drawing.Point(24, 113);
            this.bambini_button.Margin = new System.Windows.Forms.Padding(2);
            this.bambini_button.Name = "bambini_button";
            this.bambini_button.Size = new System.Drawing.Size(380, 120);
            this.bambini_button.TabIndex = 0;
            this.bambini_button.Text = "BAMBINI";
            this.bambini_button.UseVisualStyleBackColor = true;
            this.bambini_button.Click += new System.EventHandler(this.Bambini_button_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(24, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 120);
            this.button1.TabIndex = 1;
            this.button1.Text = "STATISTICHE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(24, 237);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 120);
            this.button2.TabIndex = 2;
            this.button2.Text = "LIBRI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // indietro_button
            // 
            this.indietro_button.FlatAppearance.BorderSize = 0;
            this.indietro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indietro_button.Location = new System.Drawing.Point(24, 637);
            this.indietro_button.Margin = new System.Windows.Forms.Padding(2);
            this.indietro_button.Name = "indietro_button";
            this.indietro_button.Size = new System.Drawing.Size(380, 120);
            this.indietro_button.TabIndex = 3;
            this.indietro_button.Text = "INDIETRO";
            this.indietro_button.UseVisualStyleBackColor = true;
            this.indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Bambini_page);
            this.TabControl.Controls.Add(this.Libri_page);
            this.TabControl.Controls.Add(this.Statistiche_page);
            this.TabControl.Location = new System.Drawing.Point(433, -23);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.ShowToolTips = true;
            this.TabControl.Size = new System.Drawing.Size(938, 797);
            this.TabControl.TabIndex = 4;
            this.TabControl.TabStop = false;
            // 
            // Bambini_page
            // 
            this.Bambini_page.BackColor = System.Drawing.SystemColors.Control;
            this.Bambini_page.Controls.Add(this.DelStat);
            this.Bambini_page.Controls.Add(this.StatLibri);
            this.Bambini_page.Controls.Add(this.StatBambini);
            this.Bambini_page.Location = new System.Drawing.Point(4, 22);
            this.Bambini_page.Name = "Bambini_page";
            this.Bambini_page.Padding = new System.Windows.Forms.Padding(3);
            this.Bambini_page.Size = new System.Drawing.Size(930, 771);
            this.Bambini_page.TabIndex = 0;
            // 
            // Libri_page
            // 
            this.Libri_page.BackColor = System.Drawing.SystemColors.Control;
            this.Libri_page.Location = new System.Drawing.Point(4, 22);
            this.Libri_page.Name = "Libri_page";
            this.Libri_page.Padding = new System.Windows.Forms.Padding(3);
            this.Libri_page.Size = new System.Drawing.Size(929, 744);
            this.Libri_page.TabIndex = 1;
            // 
            // Statistiche_page
            // 
            this.Statistiche_page.BackColor = System.Drawing.SystemColors.Control;
            this.Statistiche_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistiche_page.Location = new System.Drawing.Point(4, 22);
            this.Statistiche_page.Name = "Statistiche_page";
            this.Statistiche_page.Size = new System.Drawing.Size(929, 744);
            this.Statistiche_page.TabIndex = 2;
            // 
            // DelStat
            // 
            this.DelStat.Location = new System.Drawing.Point(268, 542);
            this.DelStat.Name = "DelStat";
            this.DelStat.Size = new System.Drawing.Size(380, 120);
            this.DelStat.TabIndex = 7;
            this.DelStat.Text = "ELIMINA  STATISTICHE";
            this.DelStat.UseVisualStyleBackColor = true;
            this.DelStat.Click += new System.EventHandler(this.DelStat_Click);
            // 
            // StatLibri
            // 
            this.StatLibri.Location = new System.Drawing.Point(268, 93);
            this.StatLibri.Name = "StatLibri";
            this.StatLibri.Size = new System.Drawing.Size(380, 120);
            this.StatLibri.TabIndex = 6;
            this.StatLibri.Text = "QUANTE VOLTE UN LIBRO E\' STATO LETTO";
            this.StatLibri.UseVisualStyleBackColor = true;
            this.StatLibri.Click += new System.EventHandler(this.StatLibri_Click);
            // 
            // StatBambini
            // 
            this.StatBambini.Location = new System.Drawing.Point(268, 316);
            this.StatBambini.Name = "StatBambini";
            this.StatBambini.Size = new System.Drawing.Size(380, 120);
            this.StatBambini.TabIndex = 5;
            this.StatBambini.Text = "QUANTI LIBRI HA LETTO OGNI BAMBINO";
            this.StatBambini.UseVisualStyleBackColor = true;
            this.StatBambini.Click += new System.EventHandler(this.StatBambini_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.indietro_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bambini_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - Maestre";
            this.TabControl.ResumeLayout(false);
            this.Bambini_page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bambini_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button indietro_button;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Bambini_page;
        private System.Windows.Forms.TabPage Libri_page;
        private System.Windows.Forms.TabPage Statistiche_page;
        private System.Windows.Forms.Button DelStat;
        private System.Windows.Forms.Button StatLibri;
        private System.Windows.Forms.Button StatBambini;
    }
}

