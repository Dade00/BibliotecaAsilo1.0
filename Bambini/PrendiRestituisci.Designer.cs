namespace Bambini
{
    partial class PrendiRestituisci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.help_button = new System.Windows.Forms.Button();
            this.indietro_button = new System.Windows.Forms.Button();
            this.restituisci_button = new System.Windows.Forms.Button();
            this.prendi_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // help_button
            // 
            this.help_button.FlatAppearance.BorderSize = 0;
            this.help_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_button.Location = new System.Drawing.Point(1862, 12);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(175, 193);
            this.help_button.TabIndex = 3;
            this.help_button.Text = "AIUTO";
            this.help_button.UseVisualStyleBackColor = true;
            // 
            // indietro_button
            // 
            this.indietro_button.FlatAppearance.BorderSize = 0;
            this.indietro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indietro_button.Image = global::Bambini.Properties.Resources.Indietro_button;
            this.indietro_button.Location = new System.Drawing.Point(834, 972);
            this.indietro_button.Name = "indietro_button";
            this.indietro_button.Size = new System.Drawing.Size(380, 120);
            this.indietro_button.TabIndex = 2;
            this.indietro_button.UseVisualStyleBackColor = true;
            this.indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            // 
            // restituisci_button
            // 
            this.restituisci_button.FlatAppearance.BorderSize = 0;
            this.restituisci_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restituisci_button.Image = global::Bambini.Properties.Resources.Restituisce;
            this.restituisci_button.Location = new System.Drawing.Point(1096, 382);
            this.restituisci_button.Name = "restituisci_button";
            this.restituisci_button.Size = new System.Drawing.Size(800, 418);
            this.restituisci_button.TabIndex = 1;
            this.restituisci_button.UseVisualStyleBackColor = true;
            this.restituisci_button.Click += new System.EventHandler(this.Restituisci_button_Click);
            // 
            // prendi_button
            // 
            this.prendi_button.FlatAppearance.BorderSize = 0;
            this.prendi_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prendi_button.Image = global::Bambini.Properties.Resources.PrendiV2;
            this.prendi_button.Location = new System.Drawing.Point(140, 382);
            this.prendi_button.Name = "prendi_button";
            this.prendi_button.Size = new System.Drawing.Size(800, 418);
            this.prendi_button.TabIndex = 0;
            this.prendi_button.UseVisualStyleBackColor = true;
            this.prendi_button.Click += new System.EventHandler(this.Prendi_button_Click);
            // 
            // PrendiRestituisci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2049, 1182);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.indietro_button);
            this.Controls.Add(this.restituisci_button);
            this.Controls.Add(this.prendi_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrendiRestituisci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.VisibleChanged += new System.EventHandler(this.PrendiRestituisci_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button prendi_button;
        private System.Windows.Forms.Button restituisci_button;
        private System.Windows.Forms.Button indietro_button;
        private System.Windows.Forms.Button help_button;
    }
}