namespace BibliotecaAsilo
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
            this.SuspendLayout();
            // 
            // maestre_button
            // 
            this.maestre_button.FlatAppearance.BorderSize = 0;
            this.maestre_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maestre_button.Location = new System.Drawing.Point(548, 165);
            this.maestre_button.Margin = new System.Windows.Forms.Padding(2);
            this.maestre_button.Name = "maestre_button";
            this.maestre_button.Size = new System.Drawing.Size(187, 89);
            this.maestre_button.TabIndex = 0;
            this.maestre_button.Text = "MAESTRE";
            this.maestre_button.UseVisualStyleBackColor = true;
            this.maestre_button.Click += new System.EventHandler(this.Maestre_button_Click);
            // 
            // bambini_button
            // 
            this.bambini_button.FlatAppearance.BorderSize = 0;
            this.bambini_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bambini_button.Location = new System.Drawing.Point(158, 165);
            this.bambini_button.Margin = new System.Windows.Forms.Padding(2);
            this.bambini_button.Name = "bambini_button";
            this.bambini_button.Size = new System.Drawing.Size(207, 89);
            this.bambini_button.TabIndex = 1;
            this.bambini_button.Text = "BAMBINI";
            this.bambini_button.UseVisualStyleBackColor = true;
            this.bambini_button.Click += new System.EventHandler(this.Bambini_button_Click);
            // 
            // crediti_button
            // 
            this.crediti_button.FlatAppearance.BorderSize = 0;
            this.crediti_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crediti_button.Location = new System.Drawing.Point(8, 402);
            this.crediti_button.Margin = new System.Windows.Forms.Padding(2);
            this.crediti_button.Name = "crediti_button";
            this.crediti_button.Size = new System.Drawing.Size(154, 53);
            this.crediti_button.TabIndex = 2;
            this.crediti_button.Text = "CREDITI";
            this.crediti_button.UseVisualStyleBackColor = true;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.crediti_button);
            this.Controls.Add(this.bambini_button);
            this.Controls.Add(this.maestre_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button maestre_button;
        private System.Windows.Forms.Button bambini_button;
        private System.Windows.Forms.Button crediti_button;
    }
}

