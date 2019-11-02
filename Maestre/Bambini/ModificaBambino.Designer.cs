namespace Maestre.Bambini
{
    partial class ModificaBambino
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
            this.components = new System.ComponentModel.Container();
            this.AnnullaModificaBambini = new System.Windows.Forms.Button();
            this.ConfermaModificaBambini = new System.Windows.Forms.Button();
            this.AiutoModificaBambini = new System.Windows.Forms.Button();
            this.CercaFotoBambini = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TabellaBambini = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBambini = new System.Windows.Forms.BindingSource(this.components);
            this.ClasseBambini = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.libro_label = new System.Windows.Forms.Label();
            this.CognomeBambini = new System.Windows.Forms.TextBox();
            this.NomeBambini = new System.Windows.Forms.TextBox();
            this.cognome_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bambini_pic = new System.Windows.Forms.PictureBox();
            this.nascitaBambini = new System.Windows.Forms.DateTimePicker();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // AnnullaModificaBambini
            // 
            this.AnnullaModificaBambini.BackgroundImage = global::Maestre.Properties.Resources.Annulla;
            this.AnnullaModificaBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AnnullaModificaBambini.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AnnullaModificaBambini.FlatAppearance.BorderSize = 0;
            this.AnnullaModificaBambini.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.AnnullaModificaBambini.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.AnnullaModificaBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnullaModificaBambini.Location = new System.Drawing.Point(229, 636);
            this.AnnullaModificaBambini.Name = "AnnullaModificaBambini";
            this.AnnullaModificaBambini.Size = new System.Drawing.Size(380, 120);
            this.AnnullaModificaBambini.TabIndex = 111;
            this.AnnullaModificaBambini.UseVisualStyleBackColor = true;
            this.AnnullaModificaBambini.Click += new System.EventHandler(this.AnnullaModificaBambini_Click);
            // 
            // ConfermaModificaBambini
            // 
            this.ConfermaModificaBambini.BackgroundImage = global::Maestre.Properties.Resources.Conferma;
            this.ConfermaModificaBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfermaModificaBambini.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ConfermaModificaBambini.FlatAppearance.BorderSize = 0;
            this.ConfermaModificaBambini.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.ConfermaModificaBambini.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.ConfermaModificaBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfermaModificaBambini.Location = new System.Drawing.Point(758, 637);
            this.ConfermaModificaBambini.Name = "ConfermaModificaBambini";
            this.ConfermaModificaBambini.Size = new System.Drawing.Size(380, 120);
            this.ConfermaModificaBambini.TabIndex = 110;
            this.ConfermaModificaBambini.UseVisualStyleBackColor = true;
            this.ConfermaModificaBambini.Click += new System.EventHandler(this.ConfermaModificaBambini_Click);
            // 
            // AiutoModificaBambini
            // 
            this.AiutoModificaBambini.BackgroundImage = global::Maestre.Properties.Resources.Aiuto;
            this.AiutoModificaBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AiutoModificaBambini.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AiutoModificaBambini.FlatAppearance.BorderSize = 0;
            this.AiutoModificaBambini.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.AiutoModificaBambini.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.AiutoModificaBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiutoModificaBambini.Location = new System.Drawing.Point(1235, 11);
            this.AiutoModificaBambini.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoModificaBambini.Name = "AiutoModificaBambini";
            this.AiutoModificaBambini.Size = new System.Drawing.Size(120, 120);
            this.AiutoModificaBambini.TabIndex = 109;
            this.AiutoModificaBambini.UseVisualStyleBackColor = true;
            this.AiutoModificaBambini.Click += new System.EventHandler(this.AiutoModificaBambini_Click);
            // 
            // CercaFotoBambini
            // 
            this.CercaFotoBambini.BackgroundImage = global::Maestre.Properties.Resources.Inserisci_foto;
            this.CercaFotoBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CercaFotoBambini.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.CercaFotoBambini.FlatAppearance.BorderSize = 0;
            this.CercaFotoBambini.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.CercaFotoBambini.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.CercaFotoBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CercaFotoBambini.Location = new System.Drawing.Point(444, 207);
            this.CercaFotoBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CercaFotoBambini.Name = "CercaFotoBambini";
            this.CercaFotoBambini.Size = new System.Drawing.Size(130, 45);
            this.CercaFotoBambini.TabIndex = 108;
            this.CercaFotoBambini.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(373, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 106;
            this.label3.Text = "FOTO";
            // 
            // TabellaBambini
            // 
            this.TabellaBambini.AllowUserToAddRows = false;
            this.TabellaBambini.AllowUserToDeleteRows = false;
            this.TabellaBambini.AllowUserToOrderColumns = true;
            this.TabellaBambini.AllowUserToResizeColumns = false;
            this.TabellaBambini.AllowUserToResizeRows = false;
            this.TabellaBambini.AutoGenerateColumns = false;
            this.TabellaBambini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabellaBambini.ColumnHeadersHeight = 35;
            this.TabellaBambini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TabellaBambini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn,
            this.dataNascitaDataGridViewTextBoxColumn});
            this.TabellaBambini.DataSource = this.bsBambini;
            this.TabellaBambini.Location = new System.Drawing.Point(509, 278);
            this.TabellaBambini.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaBambini.MultiSelect = false;
            this.TabellaBambini.Name = "TabellaBambini";
            this.TabellaBambini.ReadOnly = true;
            this.TabellaBambini.RowHeadersVisible = false;
            this.TabellaBambini.RowHeadersWidth = 62;
            this.TabellaBambini.RowTemplate.Height = 28;
            this.TabellaBambini.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TabellaBambini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabellaBambini.Size = new System.Drawing.Size(690, 350);
            this.TabellaBambini.TabIndex = 105;
            this.TabellaBambini.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabellaBambini_CellClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classeDataGridViewTextBoxColumn
            // 
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            this.classeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascitaDataGridViewTextBoxColumn
            // 
            this.dataNascitaDataGridViewTextBoxColumn.DataPropertyName = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn.HeaderText = "Data di nascita";
            this.dataNascitaDataGridViewTextBoxColumn.Name = "dataNascitaDataGridViewTextBoxColumn";
            this.dataNascitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsBambini
            // 
            this.bsBambini.DataSource = typeof(Classi.Bambino);
            // 
            // ClasseBambini
            // 
            this.ClasseBambini.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.ClasseBambini.Location = new System.Drawing.Point(810, 99);
            this.ClasseBambini.Margin = new System.Windows.Forms.Padding(2);
            this.ClasseBambini.Name = "ClasseBambini";
            this.ClasseBambini.Size = new System.Drawing.Size(67, 30);
            this.ClasseBambini.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(709, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 101;
            this.label1.Text = "CLASSE";
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold);
            this.libro_label.Location = new System.Drawing.Point(413, 9);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(540, 58);
            this.libro_label.TabIndex = 100;
            this.libro_label.Text = "Modifica un bambino";
            // 
            // CognomeBambini
            // 
            this.CognomeBambini.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.CognomeBambini.Location = new System.Drawing.Point(439, 158);
            this.CognomeBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CognomeBambini.Name = "CognomeBambini";
            this.CognomeBambini.Size = new System.Drawing.Size(237, 30);
            this.CognomeBambini.TabIndex = 99;
            // 
            // NomeBambini
            // 
            this.NomeBambini.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.NomeBambini.Location = new System.Drawing.Point(439, 103);
            this.NomeBambini.Margin = new System.Windows.Forms.Padding(2);
            this.NomeBambini.Name = "NomeBambini";
            this.NomeBambini.Size = new System.Drawing.Size(237, 30);
            this.NomeBambini.TabIndex = 98;
            // 
            // cognome_label
            // 
            this.cognome_label.AutoSize = true;
            this.cognome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.cognome_label.Location = new System.Drawing.Point(313, 160);
            this.cognome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cognome_label.Name = "cognome_label";
            this.cognome_label.Size = new System.Drawing.Size(125, 25);
            this.cognome_label.TabIndex = 97;
            this.cognome_label.Text = "COGNOME";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.nome_label.Location = new System.Drawing.Point(359, 105);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(76, 25);
            this.nome_label.TabIndex = 96;
            this.nome_label.Text = "NOME";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(693, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 54);
            this.label2.TabIndex = 103;
            this.label2.Text = "ANNO DI NASCITA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bambini_pic
            // 
            this.Bambini_pic.Location = new System.Drawing.Point(140, 278);
            this.Bambini_pic.Name = "Bambini_pic";
            this.Bambini_pic.Size = new System.Drawing.Size(350, 350);
            this.Bambini_pic.TabIndex = 130;
            this.Bambini_pic.TabStop = false;
            // 
            // nascitaBambini
            // 
            this.nascitaBambini.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.nascitaBambini.Location = new System.Drawing.Point(816, 155);
            this.nascitaBambini.Name = "nascitaBambini";
            this.nascitaBambini.Size = new System.Drawing.Size(322, 30);
            this.nascitaBambini.TabIndex = 131;
            // 
            // ModificaBambino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.nascitaBambini);
            this.Controls.Add(this.Bambini_pic);
            this.Controls.Add(this.AnnullaModificaBambini);
            this.Controls.Add(this.ConfermaModificaBambini);
            this.Controls.Add(this.AiutoModificaBambini);
            this.Controls.Add(this.CercaFotoBambini);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TabellaBambini);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClasseBambini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libro_label);
            this.Controls.Add(this.CognomeBambini);
            this.Controls.Add(this.NomeBambini);
            this.Controls.Add(this.cognome_label);
            this.Controls.Add(this.nome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificaBambino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificaBambino";
            this.Load += new System.EventHandler(this.ModificaBambino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBambini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnnullaModificaBambini;
        private System.Windows.Forms.Button ConfermaModificaBambini;
        private System.Windows.Forms.Button AiutoModificaBambini;
        private System.Windows.Forms.Button CercaFotoBambini;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TabellaBambini;
        private System.Windows.Forms.TextBox ClasseBambini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.TextBox CognomeBambini;
        private System.Windows.Forms.TextBox NomeBambini;
        private System.Windows.Forms.Label cognome_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Bambini_pic;
        private System.Windows.Forms.DateTimePicker nascitaBambini;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.BindingSource bsBambini;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascitaDataGridViewTextBoxColumn;
    }
}