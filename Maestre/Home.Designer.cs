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
            this.generi_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bambini_button
            // 
            this.bambini_button.FlatAppearance.BorderSize = 0;
            this.bambini_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bambini_button.Location = new System.Drawing.Point(366, 62);
            this.bambini_button.Margin = new System.Windows.Forms.Padding(2);
            this.bambini_button.Name = "bambini_button";
            this.bambini_button.Size = new System.Drawing.Size(152, 57);
            this.bambini_button.TabIndex = 0;
            this.bambini_button.Text = "BAMBINI";
            this.bambini_button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(366, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "STATISTICHE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(366, 137);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "LIBRI";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // generi_button
            // 
            this.generi_button.FlatAppearance.BorderSize = 0;
            this.generi_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generi_button.Location = new System.Drawing.Point(366, 212);
            this.generi_button.Margin = new System.Windows.Forms.Padding(2);
            this.generi_button.Name = "generi_button";
            this.generi_button.Size = new System.Drawing.Size(152, 57);
            this.generi_button.TabIndex = 3;
            this.generi_button.Text = "GENERI";
            this.generi_button.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.generi_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bambini_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home - Maestre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bambini_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button generi_button;
    }
}

