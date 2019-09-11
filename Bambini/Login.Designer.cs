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
            this.return_button = new System.Windows.Forms.Button();
            this.chisei_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.cognome_label = new System.Windows.Forms.Label();
            this.nome_textbox = new System.Windows.Forms.TextBox();
            this.cognome_textbox = new System.Windows.Forms.TextBox();
            this.treanni_button = new System.Windows.Forms.Button();
            this.cinqueanni_button = new System.Windows.Forms.Button();
            this.quattroanni_button = new System.Windows.Forms.Button();
            this.avanti_button = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // return_button
            // 
            this.return_button.FlatAppearance.BorderSize = 0;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Location = new System.Drawing.Point(215, 345);
            this.return_button.Margin = new System.Windows.Forms.Padding(2);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(171, 70);
            this.return_button.TabIndex = 2;
            this.return_button.Text = "INDIETRO";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // chisei_label
            // 
            this.chisei_label.AutoSize = true;
            this.chisei_label.Location = new System.Drawing.Point(421, 6);
            this.chisei_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chisei_label.Name = "chisei_label";
            this.chisei_label.Size = new System.Drawing.Size(51, 13);
            this.chisei_label.TabIndex = 3;
            this.chisei_label.Text = "CHI SEI?";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(194, 91);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(39, 13);
            this.nome_label.TabIndex = 4;
            this.nome_label.Text = "NOME";
            // 
            // cognome_label
            // 
            this.cognome_label.AutoSize = true;
            this.cognome_label.Location = new System.Drawing.Point(170, 125);
            this.cognome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cognome_label.Name = "cognome_label";
            this.cognome_label.Size = new System.Drawing.Size(62, 13);
            this.cognome_label.TabIndex = 5;
            this.cognome_label.Text = "COGNOME";
            // 
            // nome_textbox
            // 
            this.nome_textbox.Location = new System.Drawing.Point(245, 89);
            this.nome_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.nome_textbox.Name = "nome_textbox";
            this.nome_textbox.Size = new System.Drawing.Size(237, 20);
            this.nome_textbox.TabIndex = 6;
            // 
            // cognome_textbox
            // 
            this.cognome_textbox.Location = new System.Drawing.Point(245, 122);
            this.cognome_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.cognome_textbox.Name = "cognome_textbox";
            this.cognome_textbox.Size = new System.Drawing.Size(237, 20);
            this.cognome_textbox.TabIndex = 7;
            // 
            // treanni_button
            // 
            this.treanni_button.FlatAppearance.BorderSize = 0;
            this.treanni_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.treanni_button.Location = new System.Drawing.Point(59, 198);
            this.treanni_button.Margin = new System.Windows.Forms.Padding(2);
            this.treanni_button.Name = "treanni_button";
            this.treanni_button.Size = new System.Drawing.Size(247, 77);
            this.treanni_button.TabIndex = 8;
            this.treanni_button.Text = "TRE ANNI";
            this.treanni_button.UseVisualStyleBackColor = true;
            this.treanni_button.Click += new System.EventHandler(this.Treanni_button_Click);
            // 
            // cinqueanni_button
            // 
            this.cinqueanni_button.FlatAppearance.BorderSize = 0;
            this.cinqueanni_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinqueanni_button.Location = new System.Drawing.Point(603, 198);
            this.cinqueanni_button.Margin = new System.Windows.Forms.Padding(2);
            this.cinqueanni_button.Name = "cinqueanni_button";
            this.cinqueanni_button.Size = new System.Drawing.Size(224, 77);
            this.cinqueanni_button.TabIndex = 9;
            this.cinqueanni_button.Text = "CINQUE ANNI";
            this.cinqueanni_button.UseVisualStyleBackColor = true;
            this.cinqueanni_button.Click += new System.EventHandler(this.Cinqueanni_button_Click);
            // 
            // quattroanni_button
            // 
            this.quattroanni_button.FlatAppearance.BorderSize = 0;
            this.quattroanni_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quattroanni_button.Location = new System.Drawing.Point(336, 198);
            this.quattroanni_button.Margin = new System.Windows.Forms.Padding(2);
            this.quattroanni_button.Name = "quattroanni_button";
            this.quattroanni_button.Size = new System.Drawing.Size(227, 77);
            this.quattroanni_button.TabIndex = 10;
            this.quattroanni_button.Text = "QUATTRO ANNI";
            this.quattroanni_button.UseVisualStyleBackColor = true;
            this.quattroanni_button.Click += new System.EventHandler(this.Quattroanni_button_Click);
            // 
            // avanti_button
            // 
            this.avanti_button.FlatAppearance.BorderSize = 0;
            this.avanti_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avanti_button.Location = new System.Drawing.Point(454, 345);
            this.avanti_button.Margin = new System.Windows.Forms.Padding(2);
            this.avanti_button.Name = "avanti_button";
            this.avanti_button.Size = new System.Drawing.Size(171, 70);
            this.avanti_button.TabIndex = 11;
            this.avanti_button.Text = "AVANTI";
            this.avanti_button.UseVisualStyleBackColor = true;
            this.avanti_button.Click += new System.EventHandler(this.Avanti_button_Click);
            // 
            // help_button
            // 
            this.help_button.FlatAppearance.BorderSize = 0;
            this.help_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_button.Location = new System.Drawing.Point(709, 8);
            this.help_button.Margin = new System.Windows.Forms.Padding(2);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(179, 52);
            this.help_button.TabIndex = 12;
            this.help_button.Text = "AIUTO";
            this.help_button.UseVisualStyleBackColor = true;
            // 
            // Login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.avanti_button);
            this.Controls.Add(this.quattroanni_button);
            this.Controls.Add(this.cinqueanni_button);
            this.Controls.Add(this.treanni_button);
            this.Controls.Add(this.cognome_textbox);
            this.Controls.Add(this.nome_textbox);
            this.Controls.Add(this.cognome_label);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.chisei_label);
            this.Controls.Add(this.return_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login_page";
            this.Text = "Chi sei?";
            this.Load += new System.EventHandler(this.Login_page_Load);
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
        private System.Windows.Forms.Button treanni_button;
        private System.Windows.Forms.Button cinqueanni_button;
        private System.Windows.Forms.Button quattroanni_button;
        private System.Windows.Forms.Button avanti_button;
        private System.Windows.Forms.Button help_button;
    }
}

