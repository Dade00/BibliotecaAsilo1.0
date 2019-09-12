namespace Bambini.Prendi
{
    partial class ConfermaPresa
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.data_label = new System.Windows.Forms.Label();
            this.datastatic_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.nomelibro_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(159, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 347);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // data_label
            // 
            this.data_label.AutoSize = true;
            this.data_label.Font = new System.Drawing.Font("GROBOLD", 30F, System.Drawing.FontStyle.Bold);
            this.data_label.Location = new System.Drawing.Point(620, 402);
            this.data_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.data_label.Name = "data_label";
            this.data_label.Size = new System.Drawing.Size(314, 49);
            this.data_label.TabIndex = 13;
            this.data_label.Text = "DD/MM/YYYY";
            this.data_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // datastatic_label
            // 
            this.datastatic_label.AutoSize = true;
            this.datastatic_label.Font = new System.Drawing.Font("GROBOLD", 30F, System.Drawing.FontStyle.Bold);
            this.datastatic_label.Location = new System.Drawing.Point(620, 329);
            this.datastatic_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datastatic_label.Name = "datastatic_label";
            this.datastatic_label.Size = new System.Drawing.Size(204, 49);
            this.datastatic_label.TabIndex = 12;
            this.datastatic_label.Text = "IN DATA";
            this.datastatic_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ok_button
            // 
            this.ok_button.FlatAppearance.BorderSize = 0;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Font = new System.Drawing.Font("GROBOLD", 30F, System.Drawing.FontStyle.Bold);
            this.ok_button.Location = new System.Drawing.Point(534, 544);
            this.ok_button.Margin = new System.Windows.Forms.Padding(2);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(305, 130);
            this.ok_button.TabIndex = 11;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.Ok_button_Click_1);
            // 
            // nomelibro_label
            // 
            this.nomelibro_label.AutoSize = true;
            this.nomelibro_label.Font = new System.Drawing.Font("GROBOLD", 30F, System.Drawing.FontStyle.Bold);
            this.nomelibro_label.Location = new System.Drawing.Point(620, 256);
            this.nomelibro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomelibro_label.Name = "nomelibro_label";
            this.nomelibro_label.Size = new System.Drawing.Size(394, 49);
            this.nomelibro_label.TabIndex = 10;
            this.nomelibro_label.Text = "NOME LIBRO TEST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 40F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(148, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1070, 65);
            this.label1.TabIndex = 9;
            this.label1.Text = "IL LIBRO CHE HAI PRESO SI INTITOLA";
            // 
            // ConfermaPresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.data_label);
            this.Controls.Add(this.datastatic_label);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.nomelibro_label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfermaPresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hai preso";
            this.Load += new System.EventHandler(this.ConfermaPresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label data_label;
        private System.Windows.Forms.Label datastatic_label;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label nomelibro_label;
        private System.Windows.Forms.Label label1;
    }
}