﻿namespace Bambini.Restituiusci
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
            this.indietro_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.libro_label = new System.Windows.Forms.Label();
            this.down_button = new System.Windows.Forms.Button();
            this.up_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // indietro_button
            // 
            this.indietro_button.FlatAppearance.BorderSize = 0;
            this.indietro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indietro_button.Image = global::Bambini.Properties.Resources.Indietro_button;
            this.indietro_button.Location = new System.Drawing.Point(340, 575);
            this.indietro_button.Margin = new System.Windows.Forms.Padding(2);
            this.indietro_button.Name = "indietro_button";
            this.indietro_button.Size = new System.Drawing.Size(380, 120);
            this.indietro_button.TabIndex = 14;
            this.indietro_button.UseVisualStyleBackColor = true;
            this.indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.FlatAppearance.BorderSize = 0;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Image = global::Bambini.Properties.Resources.Avanti_button;
            this.ok_button.Location = new System.Drawing.Point(752, 575);
            this.ok_button.Margin = new System.Windows.Forms.Padding(2);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(380, 120);
            this.ok_button.TabIndex = 13;
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold);
            this.libro_label.Location = new System.Drawing.Point(303, 9);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(761, 58);
            this.libro_label.TabIndex = 12;
            this.libro_label.Text = "CHE LIBRO VUOI RESTITUIRE?";
            // 
            // down_button
            // 
            this.down_button.FlatAppearance.BorderSize = 0;
            this.down_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down_button.Image = global::Bambini.Properties.Resources.giù;
            this.down_button.Location = new System.Drawing.Point(1136, 316);
            this.down_button.Margin = new System.Windows.Forms.Padding(2);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(190, 210);
            this.down_button.TabIndex = 11;
            this.down_button.UseVisualStyleBackColor = true;
            // 
            // up_button
            // 
            this.up_button.FlatAppearance.BorderSize = 0;
            this.up_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_button.Image = global::Bambini.Properties.Resources.Su;
            this.up_button.Location = new System.Drawing.Point(1136, 102);
            this.up_button.Margin = new System.Windows.Forms.Padding(2);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(190, 210);
            this.up_button.TabIndex = 10;
            this.up_button.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 325);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(340, 102);
            this.datagrid.Margin = new System.Windows.Forms.Padding(2);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 62;
            this.datagrid.RowTemplate.Height = 28;
            this.datagrid.Size = new System.Drawing.Size(792, 424);
            this.datagrid.TabIndex = 8;
            // 
            // Librochoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.indietro_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.libro_label);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.up_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.datagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Librochoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librochoose";
            this.VisibleChanged += new System.EventHandler(this.Librochoose_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button indietro_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView datagrid;
    }
}