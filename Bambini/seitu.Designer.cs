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
            this.nome_label = new System.Windows.Forms.Label();
            this.Cognome_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.avanti_button = new System.Windows.Forms.Button();
            this.indietro_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // seitu_label
            // 
            this.seitu_label.AutoSize = true;
            this.seitu_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.seitu_label.Location = new System.Drawing.Point(578, 9);
            this.seitu_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seitu_label.Name = "seitu_label";
            this.seitu_label.Size = new System.Drawing.Size(212, 55);
            this.seitu_label.TabIndex = 0;
            this.seitu_label.Text = "SEI TU?";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.nome_label.Location = new System.Drawing.Point(491, 123);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(115, 33);
            this.nome_label.TabIndex = 2;
            this.nome_label.Text = "NOME:";
            // 
            // Cognome_label
            // 
            this.Cognome_label.AutoSize = true;
            this.Cognome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.Cognome_label.Location = new System.Drawing.Point(420, 172);
            this.Cognome_label.Name = "Cognome_label";
            this.Cognome_label.Size = new System.Drawing.Size(185, 33);
            this.Cognome_label.TabIndex = 5;
            this.Cognome_label.Text = "COGNOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(608, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "TEST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(609, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "TEST";
            // 
            // avanti_button
            // 
            this.avanti_button.FlatAppearance.BorderSize = 0;
            this.avanti_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avanti_button.Image = global::Bambini.Properties.Resources.Avanti_button;
            this.avanti_button.Location = new System.Drawing.Point(712, 577);
            this.avanti_button.Margin = new System.Windows.Forms.Padding(2);
            this.avanti_button.Name = "avanti_button";
            this.avanti_button.Size = new System.Drawing.Size(380, 120);
            this.avanti_button.TabIndex = 4;
            this.avanti_button.UseVisualStyleBackColor = true;
            this.avanti_button.Click += new System.EventHandler(this.Avanti_button_Click);
            // 
            // indietro_button
            // 
            this.indietro_button.FlatAppearance.BorderSize = 0;
            this.indietro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indietro_button.Image = global::Bambini.Properties.Resources.Indietro_button;
            this.indietro_button.Location = new System.Drawing.Point(225, 577);
            this.indietro_button.Margin = new System.Windows.Forms.Padding(2);
            this.indietro_button.Name = "indietro_button";
            this.indietro_button.Size = new System.Drawing.Size(380, 120);
            this.indietro_button.TabIndex = 3;
            this.indietro_button.UseVisualStyleBackColor = true;
            this.indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // seitu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 715);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cognome_label);
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
            this.Load += new System.EventHandler(this.Seitu_Load);
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
        private System.Windows.Forms.Label Cognome_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}