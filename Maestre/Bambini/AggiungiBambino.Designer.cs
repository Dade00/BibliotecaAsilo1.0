namespace Maestre.Bambini
{
    partial class AggiungiBambino
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
            this.AiutoAggiungiBambini = new System.Windows.Forms.Button();
            this.CercaFotoBambini = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TabellaBambini = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBambini = new System.Windows.Forms.BindingSource(this.components);
            this.ClasseAddBambini = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.libro_label = new System.Windows.Forms.Label();
            this.CognomeAddBambini = new System.Windows.Forms.TextBox();
            this.NomeAddBambini = new System.Windows.Forms.TextBox();
            this.cognome_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.Bambini_pic = new System.Windows.Forms.PictureBox();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.nascitaAddBambini = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // AnnullaModificaBambini
            // 
            this.AnnullaModificaBambini.Location = new System.Drawing.Point(222, 529);
            this.AnnullaModificaBambini.Name = "AnnullaModificaBambini";
            this.AnnullaModificaBambini.Size = new System.Drawing.Size(380, 120);
            this.AnnullaModificaBambini.TabIndex = 127;
            this.AnnullaModificaBambini.Text = "ANNULLA";
            this.AnnullaModificaBambini.UseVisualStyleBackColor = true;
            this.AnnullaModificaBambini.Click += new System.EventHandler(this.AnnullaModificaBambini_Click);
            // 
            // ConfermaModificaBambini
            // 
            this.ConfermaModificaBambini.Location = new System.Drawing.Point(748, 529);
            this.ConfermaModificaBambini.Name = "ConfermaModificaBambini";
            this.ConfermaModificaBambini.Size = new System.Drawing.Size(380, 120);
            this.ConfermaModificaBambini.TabIndex = 126;
            this.ConfermaModificaBambini.Text = "CONFERMA";
            this.ConfermaModificaBambini.UseVisualStyleBackColor = true;
            this.ConfermaModificaBambini.Click += new System.EventHandler(this.ConfermaModificaBambini_Click);
            // 
            // AiutoAggiungiBambini
            // 
            this.AiutoAggiungiBambini.Location = new System.Drawing.Point(1125, 11);
            this.AiutoAggiungiBambini.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoAggiungiBambini.Name = "AiutoAggiungiBambini";
            this.AiutoAggiungiBambini.Size = new System.Drawing.Size(230, 80);
            this.AiutoAggiungiBambini.TabIndex = 125;
            this.AiutoAggiungiBambini.Text = "AIUTO";
            this.AiutoAggiungiBambini.UseVisualStyleBackColor = true;
            // 
            // CercaFotoBambini
            // 
            this.CercaFotoBambini.Location = new System.Drawing.Point(498, 192);
            this.CercaFotoBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CercaFotoBambini.Name = "CercaFotoBambini";
            this.CercaFotoBambini.Size = new System.Drawing.Size(124, 21);
            this.CercaFotoBambini.TabIndex = 124;
            this.CercaFotoBambini.Text = "CERCA FOTO";
            this.CercaFotoBambini.UseVisualStyleBackColor = true;
            this.CercaFotoBambini.Click += new System.EventHandler(this.CercaFotoBambini_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 122;
            this.label3.Text = "FOTO";
            // 
            // TabellaBambini
            // 
            this.TabellaBambini.AllowUserToAddRows = false;
            this.TabellaBambini.AllowUserToDeleteRows = false;
            this.TabellaBambini.AutoGenerateColumns = false;
            this.TabellaBambini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabellaBambini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaBambini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn});
            this.TabellaBambini.DataSource = this.bsBambini;
            this.TabellaBambini.Location = new System.Drawing.Point(438, 261);
            this.TabellaBambini.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaBambini.Name = "TabellaBambini";
            this.TabellaBambini.RowHeadersVisible = false;
            this.TabellaBambini.RowHeadersWidth = 62;
            this.TabellaBambini.RowTemplate.Height = 28;
            this.TabellaBambini.Size = new System.Drawing.Size(690, 200);
            this.TabellaBambini.TabIndex = 121;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsBambini
            // 
            this.bsBambini.DataSource = typeof(Classi.Bambino);
            // 
            // ClasseAddBambini
            // 
            this.ClasseAddBambini.Location = new System.Drawing.Point(874, 114);
            this.ClasseAddBambini.Margin = new System.Windows.Forms.Padding(2);
            this.ClasseAddBambini.Name = "ClasseAddBambini";
            this.ClasseAddBambini.Size = new System.Drawing.Size(54, 20);
            this.ClasseAddBambini.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(799, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 117;
            this.label1.Text = "CLASSE";
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Location = new System.Drawing.Point(621, 45);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(109, 13);
            this.libro_label.TabIndex = 116;
            this.libro_label.Text = "Aggiungi Un Bambino";
            // 
            // CognomeAddBambini
            // 
            this.CognomeAddBambini.Location = new System.Drawing.Point(498, 156);
            this.CognomeAddBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CognomeAddBambini.Name = "CognomeAddBambini";
            this.CognomeAddBambini.Size = new System.Drawing.Size(237, 20);
            this.CognomeAddBambini.TabIndex = 115;
            // 
            // NomeAddBambini
            // 
            this.NomeAddBambini.Location = new System.Drawing.Point(498, 114);
            this.NomeAddBambini.Margin = new System.Windows.Forms.Padding(2);
            this.NomeAddBambini.Name = "NomeAddBambini";
            this.NomeAddBambini.Size = new System.Drawing.Size(237, 20);
            this.NomeAddBambini.TabIndex = 114;
            // 
            // cognome_label
            // 
            this.cognome_label.AutoSize = true;
            this.cognome_label.Location = new System.Drawing.Point(423, 159);
            this.cognome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cognome_label.Name = "cognome_label";
            this.cognome_label.Size = new System.Drawing.Size(62, 13);
            this.cognome_label.TabIndex = 113;
            this.cognome_label.Text = "COGNOME";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(423, 117);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(39, 13);
            this.nome_label.TabIndex = 112;
            this.nome_label.Text = "NOME";
            // 
            // Bambini_pic
            // 
            this.Bambini_pic.Location = new System.Drawing.Point(222, 261);
            this.Bambini_pic.Name = "Bambini_pic";
            this.Bambini_pic.Size = new System.Drawing.Size(204, 200);
            this.Bambini_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bambini_pic.TabIndex = 128;
            this.Bambini_pic.TabStop = false;
            // 
            // ofdFoto
            // 
            this.ofdFoto.Filter = "Foto del bambino (*.BMP;*.GIF;*.JPG;*.PNG)|*.BMP;*.GIF;*.JPG;*.PNG";
            // 
            // nascitaAddBambini
            // 
            this.nascitaAddBambini.Location = new System.Drawing.Point(918, 153);
            this.nascitaAddBambini.Name = "nascitaAddBambini";
            this.nascitaAddBambini.Size = new System.Drawing.Size(200, 20);
            this.nascitaAddBambini.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(799, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 130;
            this.label2.Text = "DATA DI NASCITA:";
            // 
            // AggiungiBambino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nascitaAddBambini);
            this.Controls.Add(this.Bambini_pic);
            this.Controls.Add(this.AnnullaModificaBambini);
            this.Controls.Add(this.ConfermaModificaBambini);
            this.Controls.Add(this.AiutoAggiungiBambini);
            this.Controls.Add(this.CercaFotoBambini);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TabellaBambini);
            this.Controls.Add(this.ClasseAddBambini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libro_label);
            this.Controls.Add(this.CognomeAddBambini);
            this.Controls.Add(this.NomeAddBambini);
            this.Controls.Add(this.cognome_label);
            this.Controls.Add(this.nome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AggiungiBambino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AggiungiBambino";
            this.Load += new System.EventHandler(this.AggiungiBambino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBambini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnnullaModificaBambini;
        private System.Windows.Forms.Button ConfermaModificaBambini;
        private System.Windows.Forms.Button AiutoAggiungiBambini;
        private System.Windows.Forms.Button CercaFotoBambini;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TabellaBambini;
        private System.Windows.Forms.TextBox ClasseAddBambini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.TextBox CognomeAddBambini;
        private System.Windows.Forms.TextBox NomeAddBambini;
        private System.Windows.Forms.Label cognome_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.PictureBox Bambini_pic;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.DateTimePicker nascitaAddBambini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsBambini;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cogomeDataGridViewTextBoxColumn;
    }
}