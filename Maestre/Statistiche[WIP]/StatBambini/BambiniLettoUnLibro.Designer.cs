﻿namespace Maestre.Statistiche_WIP_
{
    partial class BambiniLettoUnLibro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RicercaStatLibro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quanti Bambini Hanno Letto Un Determinato Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TITOLO DEL LIBRO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(633, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 2;
            // 
            // RicercaStatLibro
            // 
            this.RicercaStatLibro.Location = new System.Drawing.Point(717, 363);
            this.RicercaStatLibro.Name = "RicercaStatLibro";
            this.RicercaStatLibro.Size = new System.Drawing.Size(380, 120);
            this.RicercaStatLibro.TabIndex = 3;
            this.RicercaStatLibro.Text = "AVVIA RICERCA";
            this.RicercaStatLibro.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 120);
            this.button2.TabIndex = 4;
            this.button2.Text = "INDIETRO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BambiniLettoUnLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RicercaStatLibro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BambiniLettoUnLibro";
            this.Text = "e1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button RicercaStatLibro;
        private System.Windows.Forms.Button button2;
    }
}