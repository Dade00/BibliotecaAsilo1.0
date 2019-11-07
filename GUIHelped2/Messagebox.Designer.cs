namespace GUIHelped2
{
    partial class Messagebox
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
            this.ok_button = new System.Windows.Forms.Button();
            this.Titolo = new System.Windows.Forms.Label();
            this.testo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.BackgroundImage = global::GUIHelped2.Properties.Resources.Ok;
            this.ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ok_button.FlatAppearance.BorderSize = 0;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Location = new System.Drawing.Point(115, 180);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(170, 58);
            this.ok_button.TabIndex = 0;
            this.ok_button.UseVisualStyleBackColor = true;
            // 
            // Titolo
            // 
            this.Titolo.AutoSize = true;
            this.Titolo.Font = new System.Drawing.Font("GROBOLD", 15F);
            this.Titolo.Location = new System.Drawing.Point(165, 9);
            this.Titolo.Name = "Titolo";
            this.Titolo.Size = new System.Drawing.Size(65, 25);
            this.Titolo.TabIndex = 1;
            this.Titolo.Text = "Titolo";
            // 
            // testo
            // 
            this.testo.AutoEllipsis = true;
            this.testo.Font = new System.Drawing.Font("GROBOLD", 10F);
            this.testo.Location = new System.Drawing.Point(12, 45);
            this.testo.Name = "testo";
            this.testo.Size = new System.Drawing.Size(376, 121);
            this.testo.TabIndex = 2;
            this.testo.Text = "aa";
            this.testo.Click += new System.EventHandler(this.Testo_Click);
            // 
            // Messagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.testo);
            this.Controls.Add(this.Titolo);
            this.Controls.Add(this.ok_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Messagebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messagebox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Messagebox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label Titolo;
        private System.Windows.Forms.Label testo;
    }
}