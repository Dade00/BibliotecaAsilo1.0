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
            this.help_button.BackgroundImage = global::Bambini.Properties.Resources.Aiuto;
            this.help_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.help_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.help_button.FlatAppearance.BorderSize = 0;
            this.help_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.help_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.help_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_button.Location = new System.Drawing.Point(1159, 11);
            this.help_button.Margin = new System.Windows.Forms.Padding(2);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(123, 129);
            this.help_button.TabIndex = 3;
            this.help_button.UseVisualStyleBackColor = true;
            this.help_button.Click += new System.EventHandler(this.Help_button_Click);
            this.help_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Help_button_MouseDown);
            this.help_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Help_button_MouseUp);
            // 
            // indietro_button
            // 
            this.indietro_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.indietro_button.FlatAppearance.BorderSize = 0;
            this.indietro_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.indietro_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.indietro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indietro_button.Image = global::Bambini.Properties.Resources.Indietro_button;
            this.indietro_button.Location = new System.Drawing.Point(500, 597);
            this.indietro_button.Margin = new System.Windows.Forms.Padding(2);
            this.indietro_button.Name = "indietro_button";
            this.indietro_button.Size = new System.Drawing.Size(380, 76);
            this.indietro_button.TabIndex = 2;
            this.indietro_button.UseVisualStyleBackColor = true;
            this.indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            this.indietro_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Indietro_button_MouseDown);
            this.indietro_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Indietro_button_MouseUp);
            // 
            // restituisci_button
            // 
            this.restituisci_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.restituisci_button.FlatAppearance.BorderSize = 0;
            this.restituisci_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.restituisci_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.restituisci_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restituisci_button.Image = global::Bambini.Properties.Resources.Restituisce;
            this.restituisci_button.Location = new System.Drawing.Point(715, 222);
            this.restituisci_button.Margin = new System.Windows.Forms.Padding(2);
            this.restituisci_button.Name = "restituisci_button";
            this.restituisci_button.Size = new System.Drawing.Size(500, 270);
            this.restituisci_button.TabIndex = 1;
            this.restituisci_button.UseVisualStyleBackColor = true;
            this.restituisci_button.Click += new System.EventHandler(this.Restituisci_button_Click);
            this.restituisci_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Restituisci_button_MouseDown);
            this.restituisci_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Restituisci_button_MouseUp);
            // 
            // prendi_button
            // 
            this.prendi_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.prendi_button.FlatAppearance.BorderSize = 0;
            this.prendi_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.prendi_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.prendi_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prendi_button.Image = global::Bambini.Properties.Resources.Prendi;
            this.prendi_button.Location = new System.Drawing.Point(77, 222);
            this.prendi_button.Margin = new System.Windows.Forms.Padding(2);
            this.prendi_button.Name = "prendi_button";
            this.prendi_button.Size = new System.Drawing.Size(500, 270);
            this.prendi_button.TabIndex = 0;
            this.prendi_button.UseVisualStyleBackColor = true;
            this.prendi_button.Click += new System.EventHandler(this.Prendi_button_Click);
            this.prendi_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Prendi_button_MouseDown);
            this.prendi_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Prendi_button_MouseUp);
            // 
            // PrendiRestituisci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 715);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.indietro_button);
            this.Controls.Add(this.restituisci_button);
            this.Controls.Add(this.prendi_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrendiRestituisci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PrendiRestituisci_Load);
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