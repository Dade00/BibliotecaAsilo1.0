﻿namespace BibliotecaAsilo
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.Esci_button = new System.Windows.Forms.Button();
            this.crediti_button = new System.Windows.Forms.Button();
            this.bambini_button = new System.Windows.Forms.Button();
            this.maestre_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Esci_button
            // 
            this.Esci_button.BackColor = System.Drawing.Color.Transparent;
            this.Esci_button.FlatAppearance.BorderSize = 0;
            this.Esci_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Esci_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Esci_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Esci_button.Image = global::BibliotecaAsilo.Properties.Resources.Esci;
            this.Esci_button.Location = new System.Drawing.Point(527, 544);
            this.Esci_button.Name = "Esci_button";
            this.Esci_button.Size = new System.Drawing.Size(380, 120);
            this.Esci_button.TabIndex = 3;
            this.Esci_button.UseVisualStyleBackColor = false;
            this.Esci_button.Click += new System.EventHandler(this.Esci_button_Click);
            this.Esci_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Esci_button_MouseDown);
            this.Esci_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Esci_button_MouseUp);
            // 
            // crediti_button
            // 
            this.crediti_button.BackColor = System.Drawing.Color.Transparent;
            this.crediti_button.FlatAppearance.BorderSize = 0;
            this.crediti_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.crediti_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.crediti_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crediti_button.Image = ((System.Drawing.Image)(resources.GetObject("crediti_button.Image")));
            this.crediti_button.Location = new System.Drawing.Point(11, 561);
            this.crediti_button.Margin = new System.Windows.Forms.Padding(2);
            this.crediti_button.Name = "crediti_button";
            this.crediti_button.Size = new System.Drawing.Size(150, 174);
            this.crediti_button.TabIndex = 2;
            this.crediti_button.UseVisualStyleBackColor = false;
            this.crediti_button.Click += new System.EventHandler(this.Crediti_button_Click);
            this.crediti_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Crediti_button_MouseDown);
            this.crediti_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Crediti_button_MouseUp);
            // 
            // bambini_button
            // 
            this.bambini_button.BackColor = System.Drawing.Color.Transparent;
            this.bambini_button.BackgroundImage = global::BibliotecaAsilo.Properties.Resources.Bambini_button;
            this.bambini_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bambini_button.FlatAppearance.BorderSize = 0;
            this.bambini_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bambini_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bambini_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bambini_button.Location = new System.Drawing.Point(47, 165);
            this.bambini_button.Margin = new System.Windows.Forms.Padding(2);
            this.bambini_button.Name = "bambini_button";
            this.bambini_button.Size = new System.Drawing.Size(579, 200);
            this.bambini_button.TabIndex = 1;
            this.bambini_button.UseVisualStyleBackColor = false;
            this.bambini_button.Click += new System.EventHandler(this.Bambini_button_Click);
            this.bambini_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bambini_button_MouseDown);
            this.bambini_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bambini_button_MouseUp);
            // 
            // maestre_button
            // 
            this.maestre_button.BackColor = System.Drawing.Color.Transparent;
            this.maestre_button.BackgroundImage = global::BibliotecaAsilo.Properties.Resources.Maestra;
            this.maestre_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maestre_button.CausesValidation = false;
            this.maestre_button.FlatAppearance.BorderSize = 0;
            this.maestre_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.maestre_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.maestre_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maestre_button.Location = new System.Drawing.Point(749, 165);
            this.maestre_button.Margin = new System.Windows.Forms.Padding(2);
            this.maestre_button.Name = "maestre_button";
            this.maestre_button.Size = new System.Drawing.Size(552, 208);
            this.maestre_button.TabIndex = 0;
            this.maestre_button.UseVisualStyleBackColor = true;
            this.maestre_button.Click += new System.EventHandler(this.Maestre_button_Click);
            this.maestre_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Maestre_button_MouseDown);
            this.maestre_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Maestre_button_MouseUp);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BibliotecaAsilo.Properties.Resources.Sfondo_Home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Esci_button);
            this.Controls.Add(this.crediti_button);
            this.Controls.Add(this.bambini_button);
            this.Controls.Add(this.maestre_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button maestre_button;
        private System.Windows.Forms.Button bambini_button;
        private System.Windows.Forms.Button crediti_button;
        private System.Windows.Forms.Button Esci_button;
    }
}

