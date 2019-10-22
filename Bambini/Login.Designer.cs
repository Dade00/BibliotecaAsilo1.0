namespace Bambini
{
    partial class Login_page
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.chisei_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.cognome_label = new System.Windows.Forms.Label();
            this.nome_textbox = new System.Windows.Forms.TextBox();
            this.cognome_textbox = new System.Windows.Forms.TextBox();
            this.help_button = new System.Windows.Forms.Button();
            this.maskedGBox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.avanti_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.maskedGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // chisei_label
            // 
            this.chisei_label.AutoSize = true;
            this.chisei_label.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chisei_label.Location = new System.Drawing.Point(562, 7);
            this.chisei_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chisei_label.Name = "chisei_label";
            this.chisei_label.Size = new System.Drawing.Size(242, 67);
            this.chisei_label.TabIndex = 3;
            this.chisei_label.Text = "CHI SEI?";
            this.chisei_label.UseCompatibleTextRendering = true;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("GROBOLD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_label.Location = new System.Drawing.Point(405, 131);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(101, 33);
            this.nome_label.TabIndex = 4;
            this.nome_label.Text = "NOME";
            // 
            // cognome_label
            // 
            this.cognome_label.AutoSize = true;
            this.cognome_label.Font = new System.Drawing.Font("GROBOLD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cognome_label.Location = new System.Drawing.Point(339, 175);
            this.cognome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cognome_label.Name = "cognome_label";
            this.cognome_label.Size = new System.Drawing.Size(167, 33);
            this.cognome_label.TabIndex = 5;
            this.cognome_label.Text = "COGNOME";
            // 
            // nome_textbox
            // 
            this.nome_textbox.Font = new System.Drawing.Font("GROBOLD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_textbox.Location = new System.Drawing.Point(546, 131);
            this.nome_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.nome_textbox.Name = "nome_textbox";
            this.nome_textbox.Size = new System.Drawing.Size(392, 36);
            this.nome_textbox.TabIndex = 6;
            // 
            // cognome_textbox
            // 
            this.cognome_textbox.Font = new System.Drawing.Font("GROBOLD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cognome_textbox.Location = new System.Drawing.Point(546, 175);
            this.cognome_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.cognome_textbox.Name = "cognome_textbox";
            this.cognome_textbox.Size = new System.Drawing.Size(392, 36);
            this.cognome_textbox.TabIndex = 7;
            // 
            // help_button
            // 
            this.help_button.FlatAppearance.BorderSize = 0;
            this.help_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_button.Image = global::Bambini.Properties.Resources.Aiuto;
            this.help_button.Location = new System.Drawing.Point(1191, 7);
            this.help_button.Margin = new System.Windows.Forms.Padding(2);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(164, 170);
            this.help_button.TabIndex = 12;
            this.help_button.UseVisualStyleBackColor = true;
            this.help_button.Click += new System.EventHandler(this.Help_button_Click);
            // 
            // maskedGBox
            // 
            this.maskedGBox.BackColor = System.Drawing.SystemColors.Control;
            this.maskedGBox.Controls.Add(this.radioButton3);
            this.maskedGBox.Controls.Add(this.radioButton2);
            this.maskedGBox.Controls.Add(this.radioButton1);
            this.maskedGBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maskedGBox.Location = new System.Drawing.Point(59, 228);
            this.maskedGBox.Margin = new System.Windows.Forms.Padding(0);
            this.maskedGBox.Name = "maskedGBox";
            this.maskedGBox.Padding = new System.Windows.Forms.Padding(0);
            this.maskedGBox.Size = new System.Drawing.Size(1244, 254);
            this.maskedGBox.TabIndex = 13;
            this.maskedGBox.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.radioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.radioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("GROBOLD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Image = global::Bambini.Properties.Resources._5anni_button;
            this.radioButton3.Location = new System.Drawing.Point(914, 76);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(300, 100);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.radioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.radioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("GROBOLD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Image = global::Bambini.Properties.Resources._4anni_button;
            this.radioButton2.Location = new System.Drawing.Point(481, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(300, 100);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.radioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.radioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("GROBOLD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Image = global::Bambini.Properties.Resources._3anni_button;
            this.radioButton1.Location = new System.Drawing.Point(48, 76);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(300, 100);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // avanti_button
            // 
            this.avanti_button.FlatAppearance.BorderSize = 0;
            this.avanti_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avanti_button.Image = global::Bambini.Properties.Resources.Avanti_button;
            this.avanti_button.Location = new System.Drawing.Point(780, 572);
            this.avanti_button.Margin = new System.Windows.Forms.Padding(2);
            this.avanti_button.Name = "avanti_button";
            this.avanti_button.Size = new System.Drawing.Size(380, 120);
            this.avanti_button.TabIndex = 11;
            this.avanti_button.UseVisualStyleBackColor = true;
            this.avanti_button.Click += new System.EventHandler(this.Avanti_button_Click);
            // 
            // return_button
            // 
            this.return_button.FlatAppearance.BorderSize = 0;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Image = global::Bambini.Properties.Resources.Indietro_button;
            this.return_button.Location = new System.Drawing.Point(219, 572);
            this.return_button.Margin = new System.Windows.Forms.Padding(2);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(380, 120);
            this.return_button.TabIndex = 2;
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // Login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.maskedGBox);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.avanti_button);
            this.Controls.Add(this.cognome_textbox);
            this.Controls.Add(this.nome_textbox);
            this.Controls.Add(this.cognome_label);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.chisei_label);
            this.Controls.Add(this.return_button);
            this.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi sei?";
            this.Load += new System.EventHandler(this.Login_page_Load);
            this.maskedGBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Label chisei_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Label cognome_label;
        private System.Windows.Forms.TextBox nome_textbox;
        private System.Windows.Forms.TextBox cognome_textbox;
        private System.Windows.Forms.Button avanti_button;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.GroupBox maskedGBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

