namespace Bambini
{
    partial class seitu
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
            this.seitu_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.indietro_button = new System.Windows.Forms.Button();
            this.avanti_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // seitu_label
            // 
            this.seitu_label.AutoSize = true;
            this.seitu_label.Location = new System.Drawing.Point(403, 6);
            this.seitu_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seitu_label.Name = "seitu_label";
            this.seitu_label.Size = new System.Drawing.Size(40, 13);
            this.seitu_label.TabIndex = 0;
            this.seitu_label.Text = "Sei tu?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 244);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(337, 52);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(33, 13);
            this.nome_label.TabIndex = 2;
            this.nome_label.Text = "name";
            // 
            // indietro_button
            // 
            this.indietro_button.FlatAppearance.BorderSize = 0;
            this.indietro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indietro_button.Location = new System.Drawing.Point(262, 329);
            this.indietro_button.Margin = new System.Windows.Forms.Padding(2);
            this.indietro_button.Name = "indietro_button";
            this.indietro_button.Size = new System.Drawing.Size(380, 120);
            this.indietro_button.TabIndex = 3;
            this.indietro_button.Text = "INDIETRO";
            this.indietro_button.UseVisualStyleBackColor = true;
            this.indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            // 
            // avanti_button
            // 
            this.avanti_button.FlatAppearance.BorderSize = 0;
            this.avanti_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avanti_button.Location = new System.Drawing.Point(711, 329);
            this.avanti_button.Margin = new System.Windows.Forms.Padding(2);
            this.avanti_button.Name = "avanti_button";
            this.avanti_button.Size = new System.Drawing.Size(380, 120);
            this.avanti_button.TabIndex = 4;
            this.avanti_button.Text = "AVANTI";
            this.avanti_button.UseVisualStyleBackColor = true;
            this.avanti_button.Click += new System.EventHandler(this.Avanti_button_Click);
            // 
            // seitu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.avanti_button);
            this.Controls.Add(this.indietro_button);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.seitu_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "seitu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sei tu?";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label seitu_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Button indietro_button;
        private System.Windows.Forms.Button avanti_button;
    }
}