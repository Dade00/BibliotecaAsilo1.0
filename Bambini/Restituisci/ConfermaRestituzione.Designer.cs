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
            this.datastatic_label = new System.Windows.Forms.Label();
            this.data_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.FlatAppearance.BorderSize = 0;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Location = new System.Drawing.Point(409, 297);
            this.ok_button.Margin = new System.Windows.Forms.Padding(2);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(78, 36);
            this.ok_button.TabIndex = 5;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            // 
            // nomelibro_label
            // 
            this.nomelibro_label.AutoSize = true;
            this.nomelibro_label.Location = new System.Drawing.Point(397, 168);
            this.nomelibro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomelibro_label.Name = "nomelibro_label";
            this.nomelibro_label.Size = new System.Drawing.Size(105, 13);
            this.nomelibro_label.TabIndex = 4;
            this.nomelibro_label.Text = "NOME LIBRO TEST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IL LIBRO CHE HAI PRESO SI INTITOLA";
            // 
            // datastatic_label
            // 
            this.datastatic_label.AutoSize = true;
            this.datastatic_label.Location = new System.Drawing.Point(424, 211);
            this.datastatic_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datastatic_label.Name = "datastatic_label";
            this.datastatic_label.Size = new System.Drawing.Size(50, 13);
            this.datastatic_label.TabIndex = 6;
            this.datastatic_label.Text = "IN DATA";
            this.datastatic_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // data_label
            // 
            this.data_label.AutoSize = true;
            this.data_label.Location = new System.Drawing.Point(413, 257);
            this.data_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.data_label.Name = "data_label";
            this.data_label.Size = new System.Drawing.Size(79, 13);
            this.data_label.TabIndex = 7;
            this.data_label.Text = "DD/MM/YYYY";
            this.data_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConfermaRestituzione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.data_label);
            this.Controls.Add(this.datastatic_label);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.nomelibro_label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfermaRestituzione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfermaRestituzione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label nomelibro_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datastatic_label;
        private System.Windows.Forms.Label data_label;
    }
}