﻿namespace BibliotecaAsilo
{
    partial class Credi
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("GROBOLD", 22F);
            this.label4.Location = new System.Drawing.Point(113, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(575, 185);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gabriel S. Sartori: Grafica\r\nMatteo Bussolino: Grafica e Software\r\nDavide Zambecc" +
    "o: Grafica e Software\r\nNicolo\' Gatti: Software e Database\r\nFederico Fissore: Sof" +
    "tware\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.Credi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("GROBOLD", 24F);
            this.label3.Location = new System.Drawing.Point(216, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "prof.ssa Meinero Elena";
            this.label3.Click += new System.EventHandler(this.Credi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("GROBOLD", 28F);
            this.label2.Location = new System.Drawing.Point(286, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "2019/2020";
            this.label2.Click += new System.EventHandler(this.Credi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 30F);
            this.label1.Location = new System.Drawing.Point(219, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "ITIS Einaudi Alba";
            this.label1.Click += new System.EventHandler(this.Credi_Click);
            // 
            // Credi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BibliotecaAsilo.Properties.Resources.Sfondo_Crediti;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Credi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Credi_Load);
            this.Click += new System.EventHandler(this.Credi_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}