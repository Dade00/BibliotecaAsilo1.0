namespace Bambini.Restituiusci
{
    partial class ConfermaRestituzione
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
            this.nomelibro_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.FlatAppearance.BorderSize = 0;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Font = new System.Drawing.Font("GROBOLD", 30F, System.Drawing.FontStyle.Bold);
            this.ok_button.Image = global::Bambini.Properties.Resources.Ok;
            this.ok_button.Location = new System.Drawing.Point(531, 581);
            this.ok_button.Margin = new System.Windows.Forms.Padding(2);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(391, 130);
            this.ok_button.TabIndex = 5;
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // nomelibro_label
            // 
            this.nomelibro_label.AutoSize = true;
            this.nomelibro_label.Font = new System.Drawing.Font("GROBOLD", 28F, System.Drawing.FontStyle.Bold);
            this.nomelibro_label.Location = new System.Drawing.Point(571, 183);
            this.nomelibro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomelibro_label.Name = "nomelibro_label";
            this.nomelibro_label.Size = new System.Drawing.Size(370, 46);
            this.nomelibro_label.TabIndex = 4;
            this.nomelibro_label.Text = "NOME LIBRO TEST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1089, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "IL LIBRO CHE HAI RESTITUITO  SI INTITOLA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(149, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ConfermaRestituzione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.nomelibro_label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfermaRestituzione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfermaRestituzione";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label nomelibro_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}