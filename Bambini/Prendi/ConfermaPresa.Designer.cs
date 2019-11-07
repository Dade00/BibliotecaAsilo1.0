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
            this.pb_LIBRO = new System.Windows.Forms.PictureBox();
            this.data_label = new System.Windows.Forms.Label();
            this.datastatic_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.nomelibro_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.indietro_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LIBRO)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_LIBRO
            // 
            this.pb_LIBRO.BackColor = System.Drawing.Color.Transparent;
            this.pb_LIBRO.BackgroundImage = global::Bambini.Properties.Resources.No_image;
            this.pb_LIBRO.Location = new System.Drawing.Point(159, 167);
            this.pb_LIBRO.Name = "pb_LIBRO";
            this.pb_LIBRO.Size = new System.Drawing.Size(350, 350);
            this.pb_LIBRO.TabIndex = 14;
            this.pb_LIBRO.TabStop = false;
            // 
            // data_label
            // 
            this.data_label.AutoSize = true;
            this.data_label.BackColor = System.Drawing.Color.Transparent;
            this.data_label.Font = new System.Drawing.Font("GROBOLD", 26F, System.Drawing.FontStyle.Bold);
            this.data_label.Location = new System.Drawing.Point(620, 402);
            this.data_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.data_label.Name = "data_label";
            this.data_label.Size = new System.Drawing.Size(277, 43);
            this.data_label.TabIndex = 13;
            this.data_label.Text = "DD/MM/YYYY";
            this.data_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // datastatic_label
            // 
            this.datastatic_label.AutoSize = true;
            this.datastatic_label.BackColor = System.Drawing.Color.Transparent;
            this.datastatic_label.Font = new System.Drawing.Font("GROBOLD", 26F, System.Drawing.FontStyle.Bold);
            this.datastatic_label.Location = new System.Drawing.Point(620, 329);
            this.datastatic_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datastatic_label.Name = "datastatic_label";
            this.datastatic_label.Size = new System.Drawing.Size(180, 43);
            this.datastatic_label.TabIndex = 12;
            this.datastatic_label.Text = "IN DATA";
            this.datastatic_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.Color.Transparent;
            this.ok_button.BackgroundImage = global::Bambini.Properties.Resources.Ok;
            this.ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ok_button.FlatAppearance.BorderSize = 0;
            this.ok_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ok_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Font = new System.Drawing.Font("GROBOLD", 30F, System.Drawing.FontStyle.Bold);
            this.ok_button.Location = new System.Drawing.Point(628, 592);
            this.ok_button.Margin = new System.Windows.Forms.Padding(2);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(391, 130);
            this.ok_button.TabIndex = 11;
            this.ok_button.TabStop = false;
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.Ok_button_Click_1);
            this.ok_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ok_button_MouseDown);
            this.ok_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ok_button_MouseUp);
            // 
            // nomelibro_label
            // 
            this.nomelibro_label.AutoSize = true;
            this.nomelibro_label.BackColor = System.Drawing.Color.Transparent;
            this.nomelibro_label.Font = new System.Drawing.Font("GROBOLD", 26F, System.Drawing.FontStyle.Bold);
            this.nomelibro_label.Location = new System.Drawing.Point(620, 256);
            this.nomelibro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomelibro_label.Name = "nomelibro_label";
            this.nomelibro_label.Size = new System.Drawing.Size(347, 43);
            this.nomelibro_label.TabIndex = 10;
            this.nomelibro_label.Text = "NOME LIBRO TEST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 36.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(257, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(853, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "VUOI PRENDERE QUESTO LIBRO?";
            // 
            // indietro_button
            // 
            this.indietro_button.BackColor = System.Drawing.Color.Transparent;
            this.indietro_button.FlatAppearance.BorderSize = 0;
            this.indietro_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.indietro_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.indietro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indietro_button.Image = global::Bambini.Properties.Resources.Indietro_button;
            this.indietro_button.Location = new System.Drawing.Point(22, 630);
            this.indietro_button.Margin = new System.Windows.Forms.Padding(2);
            this.indietro_button.Name = "indietro_button";
            this.indietro_button.Size = new System.Drawing.Size(380, 76);
            this.indietro_button.TabIndex = 15;
            this.indietro_button.UseVisualStyleBackColor = false;
            this.indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            // 
            // ConfermaPresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bambini.Properties.Resources.Sfondo_che_libro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.indietro_button);
            this.Controls.Add(this.pb_LIBRO);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_LIBRO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_LIBRO;
        private System.Windows.Forms.Label data_label;
        private System.Windows.Forms.Label datastatic_label;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label nomelibro_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button indietro_button;
    }
}