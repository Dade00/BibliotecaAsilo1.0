﻿namespace Bambini.Prendi
{
    partial class Librochoose
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.up_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.libro_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.indietro_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(477, 183);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(493, 260);
            this.dataGridView2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(106, 183);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 260);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // up_button
            // 
            this.up_button.FlatAppearance.BorderSize = 0;
            this.up_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_button.Location = new System.Drawing.Point(983, 183);
            this.up_button.Margin = new System.Windows.Forms.Padding(2);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(187, 157);
            this.up_button.TabIndex = 3;
            this.up_button.Text = "SU";
            this.up_button.UseVisualStyleBackColor = true;
            // 
            // down_button
            // 
            this.down_button.FlatAppearance.BorderSize = 0;
            this.down_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down_button.Location = new System.Drawing.Point(983, 344);
            this.down_button.Margin = new System.Windows.Forms.Padding(2);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(187, 157);
            this.down_button.TabIndex = 4;
            this.down_button.Text = "GIU";
            this.down_button.UseVisualStyleBackColor = true;
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Location = new System.Drawing.Point(605, 54);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(122, 13);
            this.libro_label.TabIndex = 5;
            this.libro_label.Text = "Che libro vuoi prendere?";
            // 
            // ok_button
            // 
            this.ok_button.FlatAppearance.BorderSize = 0;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Location = new System.Drawing.Point(474, 447);
            this.ok_button.Margin = new System.Windows.Forms.Padding(2);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(243, 118);
            this.ok_button.TabIndex = 6;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // indietro_button
            // 
            this.indietro_button.FlatAppearance.BorderSize = 0;
            this.indietro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indietro_button.Location = new System.Drawing.Point(736, 447);
            this.indietro_button.Margin = new System.Windows.Forms.Padding(2);
            this.indietro_button.Name = "indietro_button";
            this.indietro_button.Size = new System.Drawing.Size(243, 118);
            this.indietro_button.TabIndex = 7;
            this.indietro_button.Text = "INDIETRO";
            this.indietro_button.UseVisualStyleBackColor = true;
            this.indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            // 
            // Librochoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.indietro_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.libro_label);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.up_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Librochoose";
            this.Text = "Librochoose";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button indietro_button;
    }
}