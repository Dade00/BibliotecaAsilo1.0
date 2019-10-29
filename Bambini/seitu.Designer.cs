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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.avanti_button = new System.Windows.Forms.Button();
            this.indietro_button = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // seitu_label
            // 
            this.seitu_label.AutoSize = true;
            this.seitu_label.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seitu_label.Location = new System.Drawing.Point(541, 9);
            this.seitu_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seitu_label.Name = "seitu_label";
            this.seitu_label.Size = new System.Drawing.Size(211, 58);
            this.seitu_label.TabIndex = 0;
            this.seitu_label.Text = "SEI TU?";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("GROBOLD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_label.Location = new System.Drawing.Point(482, 131);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(107, 33);
            this.nome_label.TabIndex = 2;
            this.nome_label.Text = "NOME:";
            // 
            // Cognome_label
            // 
            this.Cognome_label.AutoSize = true;
            this.Cognome_label.Font = new System.Drawing.Font("GROBOLD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cognome_label.Location = new System.Drawing.Point(416, 226);
            this.Cognome_label.Name = "Cognome_label";
            this.Cognome_label.Size = new System.Drawing.Size(173, 33);
            this.Cognome_label.TabIndex = 5;
            this.Cognome_label.Text = "COGNOME:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("GROBOLD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(594, 131);
            this.lblNome.Name = "label2";
            this.lblNome.Size = new System.Drawing.Size(79, 33);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "TEST";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("GROBOLD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(595, 226);
            this.lblCognome.Name = "label1";
            this.lblCognome.Size = new System.Drawing.Size(79, 33);
            this.lblCognome.TabIndex = 7;
            this.lblCognome.Text = "TEST";
            // 
            // avanti_button
            // 
            this.avanti_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.avanti_button.FlatAppearance.BorderSize = 0;
            this.avanti_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.avanti_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.avanti_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avanti_button.Image = global::Bambini.Properties.Resources.Avanti_button;
            this.avanti_button.Location = new System.Drawing.Point(711, 597);
            this.avanti_button.Margin = new System.Windows.Forms.Padding(2);
            this.avanti_button.Name = "avanti_button";
            this.avanti_button.Size = new System.Drawing.Size(380, 80);
            this.avanti_button.TabIndex = 4;
            this.avanti_button.UseVisualStyleBackColor = true;
            this.avanti_button.Click += new System.EventHandler(this.Avanti_button_Click);
            this.avanti_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Avanti_button_MouseDown);
            this.avanti_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Avanti_button_MouseUp);
            // 
            // indietro_button
            // 
            this.indietro_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.indietro_button.FlatAppearance.BorderSize = 0;
            this.indietro_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.indietro_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.indietro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indietro_button.Image = global::Bambini.Properties.Resources.Indietro_button;
            this.indietro_button.Location = new System.Drawing.Point(225, 597);
            this.indietro_button.Margin = new System.Windows.Forms.Padding(2);
            this.indietro_button.Name = "indietro_button";
            this.indietro_button.Size = new System.Drawing.Size(380, 80);
            this.indietro_button.TabIndex = 3;
            this.indietro_button.UseVisualStyleBackColor = true;
            this.indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            this.indietro_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Indietro_button_MouseDown);
            this.indietro_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Indietro_button_MouseUp);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(38, 123);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(350, 350);
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // seitu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 715);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.Cognome_label);
            this.Controls.Add(this.avanti_button);
            this.Controls.Add(this.indietro_button);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.seitu_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "seitu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sei tu?";
            this.Load += new System.EventHandler(this.Seitu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label seitu_label;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Button indietro_button;
        private System.Windows.Forms.Button avanti_button;
        private System.Windows.Forms.Label Cognome_label;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
    }
}