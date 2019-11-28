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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_page));
            this.chisei_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.cognome_label = new System.Windows.Forms.Label();
            this.nome_textbox = new System.Windows.Forms.TextBox();
            this.cognome_textbox = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.help_button = new System.Windows.Forms.Button();
            this.avanti_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.classe_label = new System.Windows.Forms.Label();
            this.classiCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chisei_label
            // 
            this.chisei_label.AutoSize = true;
            this.chisei_label.BackColor = System.Drawing.Color.Transparent;
            this.chisei_label.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold);
            this.chisei_label.Location = new System.Drawing.Point(562, 7);
            this.chisei_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chisei_label.Name = "chisei_label";
            this.chisei_label.Size = new System.Drawing.Size(242, 67);
            this.chisei_label.TabIndex = 3;
            this.chisei_label.Text = "CHI SEI?";
            this.chisei_label.UseCompatibleTextRendering = true;
            this.chisei_label.Click += new System.EventHandler(this.Chisei_label_Click);
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.BackColor = System.Drawing.Color.Transparent;
            this.nome_label.Font = new System.Drawing.Font("GROBOLD", 20.25F, System.Drawing.FontStyle.Bold);
            this.nome_label.Location = new System.Drawing.Point(405, 84);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(101, 33);
            this.nome_label.TabIndex = 4;
            this.nome_label.Text = "NOME";
            // 
            // cognome_label
            // 
            this.cognome_label.AutoSize = true;
            this.cognome_label.BackColor = System.Drawing.Color.Transparent;
            this.cognome_label.Font = new System.Drawing.Font("GROBOLD", 20.25F, System.Drawing.FontStyle.Bold);
            this.cognome_label.Location = new System.Drawing.Point(339, 130);
            this.cognome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cognome_label.Name = "cognome_label";
            this.cognome_label.Size = new System.Drawing.Size(167, 33);
            this.cognome_label.TabIndex = 5;
            this.cognome_label.Text = "COGNOME";
            // 
            // nome_textbox
            // 
            this.nome_textbox.Font = new System.Drawing.Font("GROBOLD", 20.25F, System.Drawing.FontStyle.Bold);
            this.nome_textbox.Location = new System.Drawing.Point(546, 80);
            this.nome_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.nome_textbox.Name = "nome_textbox";
            this.nome_textbox.Size = new System.Drawing.Size(392, 40);
            this.nome_textbox.TabIndex = 6;
            // 
            // cognome_textbox
            // 
            this.cognome_textbox.Font = new System.Drawing.Font("GROBOLD", 20.25F, System.Drawing.FontStyle.Bold);
            this.cognome_textbox.Location = new System.Drawing.Point(546, 126);
            this.cognome_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.cognome_textbox.Name = "cognome_textbox";
            this.cognome_textbox.Size = new System.Drawing.Size(392, 40);
            this.cognome_textbox.TabIndex = 7;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.BackgroundImage = global::Bambini.Properties.Resources._5anni_button;
            this.radioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(897, 69);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(344, 115);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            this.radioButton3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RadioButton3_MouseDown);
            this.radioButton3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RadioButton3_MouseUp);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackgroundImage = global::Bambini.Properties.Resources._4anni_button;
            this.radioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(450, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(344, 115);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            this.radioButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RadioButton2_MouseDown);
            this.radioButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RadioButton2_MouseUp);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackgroundImage = global::Bambini.Properties.Resources._3anni_button;
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(3, 69);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(344, 115);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            this.radioButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RadioButton1_MouseDown);
            this.radioButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RadioButton1_MouseUp);
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.Transparent;
            this.help_button.BackgroundImage = global::Bambini.Properties.Resources.Aiuto;
            this.help_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.help_button.FlatAppearance.BorderSize = 0;
            this.help_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.help_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.help_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.help_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_button.Location = new System.Drawing.Point(1251, 7);
            this.help_button.Margin = new System.Windows.Forms.Padding(2);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(104, 110);
            this.help_button.TabIndex = 12;
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.Help_button_Click);
            this.help_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Help_button_MouseDown);
            this.help_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Help_button_MouseUp);
            // 
            // avanti_button
            // 
            this.avanti_button.BackColor = System.Drawing.Color.Transparent;
            this.avanti_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("avanti_button.BackgroundImage")));
            this.avanti_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avanti_button.FlatAppearance.BorderSize = 0;
            this.avanti_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.avanti_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.avanti_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.avanti_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avanti_button.Location = new System.Drawing.Point(780, 590);
            this.avanti_button.Margin = new System.Windows.Forms.Padding(2);
            this.avanti_button.Name = "avanti_button";
            this.avanti_button.Size = new System.Drawing.Size(396, 85);
            this.avanti_button.TabIndex = 11;
            this.avanti_button.UseVisualStyleBackColor = true;
            this.avanti_button.Click += new System.EventHandler(this.Avanti_button_Click);
            this.avanti_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Avanti_button_MouseDown);
            this.avanti_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Avanti_button_MouseUp);
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.Transparent;
            this.return_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.return_button.FlatAppearance.BorderSize = 0;
            this.return_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.return_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.return_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Image = global::Bambini.Properties.Resources.Indietro_button;
            this.return_button.Location = new System.Drawing.Point(218, 590);
            this.return_button.Margin = new System.Windows.Forms.Padding(2);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(396, 85);
            this.return_button.TabIndex = 2;
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.Return_button_Click);
            this.return_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Return_button_MouseDown);
            this.return_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Return_button_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(59, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 254);
            this.panel1.TabIndex = 14;
            // 
            // classe_label
            // 
            this.classe_label.AutoSize = true;
            this.classe_label.BackColor = System.Drawing.Color.Transparent;
            this.classe_label.Font = new System.Drawing.Font("GROBOLD", 20.25F, System.Drawing.FontStyle.Bold);
            this.classe_label.Location = new System.Drawing.Point(379, 176);
            this.classe_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classe_label.Name = "classe_label";
            this.classe_label.Size = new System.Drawing.Size(127, 33);
            this.classe_label.TabIndex = 15;
            this.classe_label.Text = "CLASSE";
            // 
            // classiCB
            // 
            this.classiCB.BackColor = System.Drawing.SystemColors.Window;
            this.classiCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classiCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classiCB.Font = new System.Drawing.Font("GROBOLD", 20.25F, System.Drawing.FontStyle.Bold);
            this.classiCB.FormattingEnabled = true;
            this.classiCB.Location = new System.Drawing.Point(546, 172);
            this.classiCB.MaxDropDownItems = 12;
            this.classiCB.Name = "classiCB";
            this.classiCB.Size = new System.Drawing.Size(95, 41);
            this.classiCB.TabIndex = 16;
            // 
            // Login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bambini.Properties.Resources.Sfondo_Login;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.classiCB);
            this.Controls.Add(this.classe_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.avanti_button);
            this.Controls.Add(this.cognome_textbox);
            this.Controls.Add(this.nome_textbox);
            this.Controls.Add(this.cognome_label);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.chisei_label);
            this.Controls.Add(this.return_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi sei?";
            this.Load += new System.EventHandler(this.Login_page_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label classe_label;
        private System.Windows.Forms.ComboBox classiCB;
    }
}

