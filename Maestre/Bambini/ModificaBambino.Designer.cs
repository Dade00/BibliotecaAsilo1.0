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
            this.ClasseModBambini = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.libro_label = new System.Windows.Forms.Label();
            this.CognomeModBambini = new System.Windows.Forms.TextBox();
            this.NomeModBambini = new System.Windows.Forms.TextBox();
            this.cognome_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nascitaModificaBambini = new System.Windows.Forms.DateTimePicker();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cognome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBambini = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AnnullaModificaBambini
            // 
            this.AnnullaModificaBambini.Location = new System.Drawing.Point(226, 544);
            this.AnnullaModificaBambini.Name = "AnnullaModificaBambini";
            this.AnnullaModificaBambini.Size = new System.Drawing.Size(380, 120);
            this.AnnullaModificaBambini.TabIndex = 111;
            this.AnnullaModificaBambini.Text = "ANNULLA";
            this.AnnullaModificaBambini.UseVisualStyleBackColor = true;
            this.AnnullaModificaBambini.Click += new System.EventHandler(this.AnnullaModificaBambini_Click);
            // 
            // ConfermaModificaBambini
            // 
            this.ConfermaModificaBambini.Location = new System.Drawing.Point(761, 544);
            this.ConfermaModificaBambini.Name = "ConfermaModificaBambini";
            this.ConfermaModificaBambini.Size = new System.Drawing.Size(380, 120);
            this.ConfermaModificaBambini.TabIndex = 110;
            this.ConfermaModificaBambini.Text = "CONFERMA";
            this.ConfermaModificaBambini.UseVisualStyleBackColor = true;
            this.ConfermaModificaBambini.Click += new System.EventHandler(this.ConfermaModificaBambini_Click);
            // 
            // AiutoModificaBambini
            // 
            this.AiutoModificaBambini.Location = new System.Drawing.Point(1125, 11);
            this.AiutoModificaBambini.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoModificaBambini.Name = "AiutoModificaBambini";
            this.AiutoModificaBambini.Size = new System.Drawing.Size(230, 80);
            this.AiutoModificaBambini.TabIndex = 109;
            this.AiutoModificaBambini.Text = "AIUTO";
            this.AiutoModificaBambini.UseVisualStyleBackColor = true;
            // 
            // CercaFotoBambini
            // 
            this.CercaFotoBambini.Location = new System.Drawing.Point(509, 208);
            this.CercaFotoBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CercaFotoBambini.Name = "CercaFotoBambini";
            this.CercaFotoBambini.Size = new System.Drawing.Size(101, 20);
            this.CercaFotoBambini.TabIndex = 108;
            this.CercaFotoBambini.Text = "CERCA FOTO";
            this.CercaFotoBambini.UseVisualStyleBackColor = true;
            this.CercaFotoBambini.Click += new System.EventHandler(this.CercaFotoBambini_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "FOTO";
            // 
            // ClasseModBambini
            // 
            this.ClasseModBambini.Location = new System.Drawing.Point(878, 120);
            this.ClasseModBambini.Margin = new System.Windows.Forms.Padding(2);
            this.ClasseModBambini.Name = "ClasseModBambini";
            this.ClasseModBambini.Size = new System.Drawing.Size(54, 20);
            this.ClasseModBambini.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(803, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "CLASSE";
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Location = new System.Drawing.Point(672, 45);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(108, 13);
            this.libro_label.TabIndex = 100;
            this.libro_label.Text = "Modifica Un Bambino";
            // 
            // CognomeModBambini
            // 
            this.CognomeModBambini.Location = new System.Drawing.Point(509, 163);
            this.CognomeModBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CognomeModBambini.Name = "CognomeModBambini";
            this.CognomeModBambini.Size = new System.Drawing.Size(237, 20);
            this.CognomeModBambini.TabIndex = 99;
            // 
            // NomeModBambini
            // 
            this.NomeModBambini.Location = new System.Drawing.Point(509, 120);
            this.NomeModBambini.Margin = new System.Windows.Forms.Padding(2);
            this.NomeModBambini.Name = "NomeModBambini";
            this.NomeModBambini.Size = new System.Drawing.Size(237, 20);
            this.NomeModBambini.TabIndex = 98;
            // 
            // cognome_label
            // 
            this.cognome_label.AutoSize = true;
            this.cognome_label.Location = new System.Drawing.Point(434, 166);
            this.cognome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cognome_label.Name = "cognome_label";
            this.cognome_label.Size = new System.Drawing.Size(62, 13);
            this.cognome_label.TabIndex = 97;
            this.cognome_label.Text = "COGNOME";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(434, 123);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(39, 13);
            this.nome_label.TabIndex = 96;
            this.nome_label.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(803, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "DATA DI NASCITA:";
            // 
            // nascitaModificaBambini
            // 
            this.nascitaModificaBambini.Location = new System.Drawing.Point(922, 160);
            this.nascitaModificaBambini.Name = "nascitaModificaBambini";
            this.nascitaModificaBambini.Size = new System.Drawing.Size(200, 20);
            this.nascitaModificaBambini.TabIndex = 131;
            // 
            // ofdFoto
            // 
            this.ofdFoto.Filter = "Foto del bambino (*.BMP;*.GIF;*.JPG;*.PNG)|*.BMP;*.GIF;*.JPG;*.PNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Cognome,
            this.DataNascita,
            this.Classe});
            this.dataGridView1.DataSource = this.bsBambini;
            this.dataGridView1.Location = new System.Drawing.Point(452, 275);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(690, 200);
            this.dataGridView1.TabIndex = 133;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Cognome
            // 
            this.Cognome.DataPropertyName = "Cognome";
            this.Cognome.HeaderText = "Cognome";
            this.Cognome.Name = "Cognome";
            // 
            // DataNascita
            // 
            this.DataNascita.DataPropertyName = "DataNascita";
            this.DataNascita.HeaderText = "DataNascita";
            this.DataNascita.Name = "DataNascita";
            // 
            // Classe
            // 
            this.Classe.DataPropertyName = "Classe";
            this.Classe.HeaderText = "Classe";
            this.Classe.Name = "Classe";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bsBambini
            // 
            this.bsBambini.DataSource = typeof(Classi.Bambino);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(226, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 134;
            this.pictureBox1.TabStop = false;
            // 
            // ModificaBambino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nascitaModificaBambini);
            this.Controls.Add(this.AnnullaModificaBambini);
            this.Controls.Add(this.ConfermaModificaBambini);
            this.Controls.Add(this.AiutoModificaBambini);
            this.Controls.Add(this.CercaFotoBambini);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClasseModBambini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libro_label);
            this.Controls.Add(this.CognomeModBambini);
            this.Controls.Add(this.NomeModBambini);
            this.Controls.Add(this.cognome_label);
            this.Controls.Add(this.nome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificaBambino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificaBambino";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBambini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnnullaModificaBambini;
        private System.Windows.Forms.Button ConfermaModificaBambini;
        private System.Windows.Forms.Button AiutoModificaBambini;
        private System.Windows.Forms.Button CercaFotoBambini;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClasseModBambini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.TextBox CognomeModBambini;
        private System.Windows.Forms.TextBox NomeModBambini;
        private System.Windows.Forms.Label cognome_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker nascitaModificaBambini;
        private System.Windows.Forms.BindingSource bsBambini;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cognome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}