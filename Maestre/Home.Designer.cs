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
            this.indietro_button = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Bambini_page = new System.Windows.Forms.TabPage();
            this.Libri_page = new System.Windows.Forms.TabPage();
            this.Statistiche_page = new System.Windows.Forms.TabPage();
            this.EliminaBambino = new System.Windows.Forms.Button();
            this.ModificaBambino = new System.Windows.Forms.Button();
            this.AggiungiBambino = new System.Windows.Forms.Button();
            this.EliminaLibro = new System.Windows.Forms.Button();
            this.ModificaLibro = new System.Windows.Forms.Button();
            this.AggiungiLibro = new System.Windows.Forms.Button();
            this.DelStat = new System.Windows.Forms.Button();
            this.StatLibri = new System.Windows.Forms.Button();
            this.StatBambini = new System.Windows.Forms.Button();
            this.Bambini_radio = new System.Windows.Forms.RadioButton();
            this.Libri_radio = new System.Windows.Forms.RadioButton();
            this.Statistiche_radio = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.Bambini_page.SuspendLayout();
            this.Libri_page.SuspendLayout();
            this.Statistiche_page.SuspendLayout();
            this.SuspendLayout();
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
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Location = new System.Drawing.Point(588, -30);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.ShowToolTips = true;
            this.TabControl.Size = new System.Drawing.Size(819, 822);
            this.TabControl.TabIndex = 4;
            this.TabControl.TabStop = false;
            // 
            // Bambini_page
            // 
            this.Bambini_page.BackColor = System.Drawing.SystemColors.Control;
            this.Bambini_page.Controls.Add(this.EliminaBambino);
            this.Bambini_page.Controls.Add(this.ModificaBambino);
            this.Bambini_page.Controls.Add(this.AggiungiBambino);
            this.Bambini_page.Location = new System.Drawing.Point(4, 22);
            this.Bambini_page.Name = "Bambini_page";
            this.Bambini_page.Padding = new System.Windows.Forms.Padding(3);
            this.Bambini_page.Size = new System.Drawing.Size(811, 796);
            this.Bambini_page.TabIndex = 0;
            // 
            // Libri_page
            // 
            this.Libri_page.BackColor = System.Drawing.SystemColors.Control;
            this.Libri_page.Controls.Add(this.EliminaLibro);
            this.Libri_page.Controls.Add(this.ModificaLibro);
            this.Libri_page.Controls.Add(this.AggiungiLibro);
            this.Libri_page.Location = new System.Drawing.Point(4, 22);
            this.Libri_page.Name = "Libri_page";
            this.Libri_page.Padding = new System.Windows.Forms.Padding(3);
            this.Libri_page.Size = new System.Drawing.Size(797, 742);
            this.Libri_page.TabIndex = 1;
            // 
            // Statistiche_page
            // 
            this.Statistiche_page.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Statistiche_page.Controls.Add(this.DelStat);
            this.Statistiche_page.Controls.Add(this.StatLibri);
            this.Statistiche_page.Controls.Add(this.StatBambini);
            this.Statistiche_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistiche_page.Location = new System.Drawing.Point(4, 22);
            this.Statistiche_page.Name = "Statistiche_page";
            this.Statistiche_page.Size = new System.Drawing.Size(811, 778);
            this.Statistiche_page.TabIndex = 2;
            // 
            // EliminaBambino
            // 
            this.EliminaBambino.Location = new System.Drawing.Point(145, 489);
            this.EliminaBambino.Name = "EliminaBambino";
            this.EliminaBambino.Size = new System.Drawing.Size(380, 120);
            this.EliminaBambino.TabIndex = 5;
            this.EliminaBambino.Text = "ELIMINA BAMBINO";
            this.EliminaBambino.UseVisualStyleBackColor = true;
            // 
            // ModificaBambino
            // 
            this.ModificaBambino.Location = new System.Drawing.Point(145, 300);
            this.ModificaBambino.Name = "ModificaBambino";
            this.ModificaBambino.Size = new System.Drawing.Size(380, 120);
            this.ModificaBambino.TabIndex = 4;
            this.ModificaBambino.Text = "MODIFICA BAMBINO";
            this.ModificaBambino.UseVisualStyleBackColor = true;
            this.ModificaBambino.Click += new System.EventHandler(this.ModificaBambino_Click);
            // 
            // AggiungiBambino
            // 
            this.AggiungiBambino.Location = new System.Drawing.Point(145, 111);
            this.AggiungiBambino.Name = "AggiungiBambino";
            this.AggiungiBambino.Size = new System.Drawing.Size(380, 120);
            this.AggiungiBambino.TabIndex = 3;
            this.AggiungiBambino.Text = "AGGIUNGI BAMBINO";
            this.AggiungiBambino.UseVisualStyleBackColor = true;
            this.AggiungiBambino.Click += new System.EventHandler(this.AggiungiBambino_Click);
            // 
            // EliminaLibro
            // 
            this.EliminaLibro.Location = new System.Drawing.Point(151, 489);
            this.EliminaLibro.Name = "EliminaLibro";
            this.EliminaLibro.Size = new System.Drawing.Size(380, 120);
            this.EliminaLibro.TabIndex = 8;
            this.EliminaLibro.Text = "ELIMINA LIBRO";
            this.EliminaLibro.UseVisualStyleBackColor = true;
            this.EliminaLibro.Click += new System.EventHandler(this.EliminaLibro_Click);
            // 
            // ModificaLibro
            // 
            this.ModificaLibro.Location = new System.Drawing.Point(151, 300);
            this.ModificaLibro.Name = "ModificaLibro";
            this.ModificaLibro.Size = new System.Drawing.Size(380, 120);
            this.ModificaLibro.TabIndex = 7;
            this.ModificaLibro.Text = "MODIFICA LIBRO";
            this.ModificaLibro.UseVisualStyleBackColor = true;
            this.ModificaLibro.Click += new System.EventHandler(this.ModificaLibro_Click);
            // 
            // AggiungiLibro
            // 
            this.AggiungiLibro.Location = new System.Drawing.Point(151, 111);
            this.AggiungiLibro.Name = "AggiungiLibro";
            this.AggiungiLibro.Size = new System.Drawing.Size(380, 120);
            this.AggiungiLibro.TabIndex = 6;
            this.AggiungiLibro.Text = "AGGIUNGI LIBRO";
            this.AggiungiLibro.UseVisualStyleBackColor = true;
            this.AggiungiLibro.Click += new System.EventHandler(this.AggiungiLibro_Click);
            // 
            // DelStat
            // 
            this.DelStat.Location = new System.Drawing.Point(151, 489);
            this.DelStat.Name = "DelStat";
            this.DelStat.Size = new System.Drawing.Size(380, 120);
            this.DelStat.TabIndex = 6;
            this.DelStat.Text = "ELIMINA  STATISTICHE";
            this.DelStat.UseVisualStyleBackColor = true;
            // 
            // StatLibri
            // 
            this.StatLibri.Location = new System.Drawing.Point(151, 300);
            this.StatLibri.Name = "StatLibri";
            this.StatLibri.Size = new System.Drawing.Size(380, 120);
            this.StatLibri.TabIndex = 5;
            this.StatLibri.Text = "QUANTE VOLTE UN LIBRO E\' STATO LETTO";
            this.StatLibri.UseVisualStyleBackColor = true;
            this.StatLibri.Click += new System.EventHandler(this.StatLibri_Click_1);
            // 
            // StatBambini
            // 
            this.StatBambini.Location = new System.Drawing.Point(151, 111);
            this.StatBambini.Name = "StatBambini";
            this.StatBambini.Size = new System.Drawing.Size(380, 120);
            this.StatBambini.TabIndex = 4;
            this.StatBambini.Text = "QUANTI LIBRI HA LETTO OGNI BAMBINO";
            this.StatBambini.UseVisualStyleBackColor = true;
            this.StatBambini.Click += new System.EventHandler(this.StatBambini_Click_1);
            // 
            // Bambini_radio
            // 
            this.Bambini_radio.Appearance = System.Windows.Forms.Appearance.Button;
            this.Bambini_radio.Location = new System.Drawing.Point(52, 134);
            this.Bambini_radio.Name = "Bambini_radio";
            this.Bambini_radio.Size = new System.Drawing.Size(380, 120);
            this.Bambini_radio.TabIndex = 5;
            this.Bambini_radio.TabStop = true;
            this.Bambini_radio.Text = "BAMBINI";
            this.Bambini_radio.UseVisualStyleBackColor = true;
            this.Bambini_radio.CheckedChanged += new System.EventHandler(this.Bambini_radio_CheckedChanged);
            // 
            // Libri_radio
            // 
            this.Libri_radio.Appearance = System.Windows.Forms.Appearance.Button;
            this.Libri_radio.Location = new System.Drawing.Point(52, 323);
            this.Libri_radio.Name = "Libri_radio";
            this.Libri_radio.Size = new System.Drawing.Size(380, 120);
            this.Libri_radio.TabIndex = 6;
            this.Libri_radio.TabStop = true;
            this.Libri_radio.Text = "LIBRI";
            this.Libri_radio.UseVisualStyleBackColor = true;
            this.Libri_radio.CheckedChanged += new System.EventHandler(this.Libri_radio_CheckedChanged);
            // 
            // Statistiche_radio
            // 
            this.Statistiche_radio.Appearance = System.Windows.Forms.Appearance.Button;
            this.Statistiche_radio.Location = new System.Drawing.Point(52, 512);
            this.Statistiche_radio.Name = "Statistiche_radio";
            this.Statistiche_radio.Size = new System.Drawing.Size(380, 120);
            this.Statistiche_radio.TabIndex = 7;
            this.Statistiche_radio.TabStop = true;
            this.Statistiche_radio.Text = "STATISTICHE";
            this.Statistiche_radio.UseVisualStyleBackColor = true;
            this.Statistiche_radio.CheckedChanged += new System.EventHandler(this.Statistiche_radio_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(811, 778);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Statistiche_radio);
            this.Controls.Add(this.Libri_radio);
            this.Controls.Add(this.Bambini_radio);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.indietro_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - Maestre";
            this.Load += new System.EventHandler(this.Home_Load);
            this.VisibleChanged += new System.EventHandler(this.Home_VisibleChanged);
            this.TabControl.ResumeLayout(false);
            this.Bambini_page.ResumeLayout(false);
            this.Libri_page.ResumeLayout(false);
            this.Statistiche_page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button indietro_button;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Bambini_page;
        private System.Windows.Forms.TabPage Libri_page;
        private System.Windows.Forms.TabPage Statistiche_page;
        private System.Windows.Forms.Button EliminaBambino;
        private System.Windows.Forms.Button ModificaBambino;
        private System.Windows.Forms.Button AggiungiBambino;
        private System.Windows.Forms.Button EliminaLibro;
        private System.Windows.Forms.Button ModificaLibro;
        private System.Windows.Forms.Button AggiungiLibro;
        private System.Windows.Forms.Button DelStat;
        private System.Windows.Forms.Button StatLibri;
        private System.Windows.Forms.Button StatBambini;
        private System.Windows.Forms.RadioButton Bambini_radio;
        private System.Windows.Forms.RadioButton Libri_radio;
        private System.Windows.Forms.RadioButton Statistiche_radio;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

