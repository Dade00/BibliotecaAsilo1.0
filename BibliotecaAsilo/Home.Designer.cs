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
            this.maestre_button = new System.Windows.Forms.Button();
            this.bambini_button = new System.Windows.Forms.Button();
            this.crediti_button = new System.Windows.Forms.Button();
            this.Esci_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maestre_button
            // 
            this.maestre_button.FlatAppearance.BorderSize = 0;
            this.maestre_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.maestre_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.maestre_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maestre_button.Image = global::BibliotecaAsilo.Properties.Resources.Maestra_button;
            this.maestre_button.Location = new System.Drawing.Point(1104, 228);
            this.maestre_button.Name = "maestre_button";
            this.maestre_button.Size = new System.Drawing.Size(810, 308);
            this.maestre_button.TabIndex = 0;
            this.maestre_button.UseVisualStyleBackColor = true;
            this.maestre_button.Click += new System.EventHandler(this.Maestre_button_Click);
            // 
            // bambini_button
            // 
            this.bambini_button.FlatAppearance.BorderSize = 0;
            this.bambini_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.bambini_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bambini_button.Image = global::BibliotecaAsilo.Properties.Resources.Bambini_button;
            this.bambini_button.Location = new System.Drawing.Point(114, 228);
            this.bambini_button.Name = "bambini_button";
            this.bambini_button.Size = new System.Drawing.Size(810, 308);
            this.bambini_button.TabIndex = 1;
            this.bambini_button.UseVisualStyleBackColor = true;
            this.bambini_button.Click += new System.EventHandler(this.Bambini_button_Click);
            // 
            // crediti_button
            // 
            this.crediti_button.FlatAppearance.BorderSize = 0;
            this.crediti_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crediti_button.Location = new System.Drawing.Point(12, 945);
            this.crediti_button.Name = "crediti_button";
            this.crediti_button.Size = new System.Drawing.Size(210, 225);
            this.crediti_button.TabIndex = 2;
            this.crediti_button.Text = "CREDITI";
            this.crediti_button.UseVisualStyleBackColor = true;
            // 
            // Esci_button
            // 
            this.Esci_button.FlatAppearance.BorderSize = 0;
            this.Esci_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Esci_button.Location = new System.Drawing.Point(732, 785);
            this.Esci_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Esci_button.Name = "Esci_button";
            this.Esci_button.Size = new System.Drawing.Size(570, 185);
            this.Esci_button.TabIndex = 3;
            this.Esci_button.Text = "Esci";
            this.Esci_button.UseVisualStyleBackColor = true;
            this.Esci_button.Click += new System.EventHandler(this.Esci_button_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2049, 1182);
            this.Controls.Add(this.Esci_button);
            this.Controls.Add(this.crediti_button);
            this.Controls.Add(this.bambini_button);
            this.Controls.Add(this.maestre_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button maestre_button;
        private System.Windows.Forms.Button bambini_button;
        private System.Windows.Forms.Button crediti_button;
        private System.Windows.Forms.Button Esci_button;
    }
}

