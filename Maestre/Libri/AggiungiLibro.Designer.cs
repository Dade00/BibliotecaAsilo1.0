namespace Maestre.Libri
{
    partial class AggiungiLibro
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
            this.AnnullaModificaLibro = new System.Windows.Forms.Button();
            this.ConfermaModificaLibro = new System.Windows.Forms.Button();
            this.AiutoModificaLibro = new System.Windows.Forms.Button();
            this.InserisciFotoLibro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CodiceAddLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenereAddLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.libro_label = new System.Windows.Forms.Label();
            this.AutoreAddLibro = new System.Windows.Forms.TextBox();
            this.TitoloAddLibro = new System.Windows.Forms.TextBox();
            this.cognome_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.Libri_pic = new System.Windows.Forms.PictureBox();
            this.Libri = new System.Windows.Forms.DataGridView();
            this.bsLibri = new System.Windows.Forms.BindingSource(this.components);
            this.titoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestitoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Libri_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).BeginInit();
            this.SuspendLayout();
            // 
            // AnnullaModificaLibro
            // 
            this.AnnullaModificaLibro.BackgroundImage = global::Maestre.Properties.Resources.Annulla;
            this.AnnullaModificaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AnnullaModificaLibro.FlatAppearance.BorderSize = 0;
            this.AnnullaModificaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnullaModificaLibro.Location = new System.Drawing.Point(229, 636);
            this.AnnullaModificaLibro.Name = "AnnullaModificaLibro";
            this.AnnullaModificaLibro.Size = new System.Drawing.Size(380, 120);
            this.AnnullaModificaLibro.TabIndex = 95;
            this.AnnullaModificaLibro.UseVisualStyleBackColor = true;
            this.AnnullaModificaLibro.Click += new System.EventHandler(this.AnnullaModificaLibro_Click);
            // 
            // ConfermaModificaLibro
            // 
            this.ConfermaModificaLibro.BackgroundImage = global::Maestre.Properties.Resources.Conferma;
            this.ConfermaModificaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfermaModificaLibro.FlatAppearance.BorderSize = 0;
            this.ConfermaModificaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfermaModificaLibro.Location = new System.Drawing.Point(758, 637);
            this.ConfermaModificaLibro.Name = "ConfermaModificaLibro";
            this.ConfermaModificaLibro.Size = new System.Drawing.Size(380, 120);
            this.ConfermaModificaLibro.TabIndex = 94;
            this.ConfermaModificaLibro.UseVisualStyleBackColor = true;
            this.ConfermaModificaLibro.Click += new System.EventHandler(this.ConfermaModificaLibro_Click);
            // 
            // AiutoModificaLibro
            // 
            this.AiutoModificaLibro.BackgroundImage = global::Maestre.Properties.Resources.Aiuto;
            this.AiutoModificaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AiutoModificaLibro.FlatAppearance.BorderSize = 0;
            this.AiutoModificaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiutoModificaLibro.Location = new System.Drawing.Point(1235, 11);
            this.AiutoModificaLibro.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoModificaLibro.Name = "AiutoModificaLibro";
            this.AiutoModificaLibro.Size = new System.Drawing.Size(120, 120);
            this.AiutoModificaLibro.TabIndex = 93;
            this.AiutoModificaLibro.UseVisualStyleBackColor = true;
            // 
            // InserisciFotoLibro
            // 
            this.InserisciFotoLibro.BackgroundImage = global::Maestre.Properties.Resources.Inserisci_foto;
            this.InserisciFotoLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InserisciFotoLibro.FlatAppearance.BorderSize = 0;
            this.InserisciFotoLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InserisciFotoLibro.Location = new System.Drawing.Point(444, 207);
            this.InserisciFotoLibro.Margin = new System.Windows.Forms.Padding(2);
            this.InserisciFotoLibro.Name = "InserisciFotoLibro";
            this.InserisciFotoLibro.Size = new System.Drawing.Size(130, 45);
            this.InserisciFotoLibro.TabIndex = 92;
            this.InserisciFotoLibro.UseVisualStyleBackColor = true;
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
            this.label3.TabIndex = 90;
            this.label3.Text = "FOTO";
            // 
            // CodiceAddLibro
            // 
            this.CodiceAddLibro.Font = new System.Drawing.Font("GROBOLD", 10F);
            this.CodiceAddLibro.Location = new System.Drawing.Point(816, 162);
            this.CodiceAddLibro.Margin = new System.Windows.Forms.Padding(2);
            this.CodiceAddLibro.Name = "CodiceAddLibro";
            this.CodiceAddLibro.Size = new System.Drawing.Size(121, 23);
            this.CodiceAddLibro.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(714, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "CODICE";
            // 
            // GenereAddLibro
            // 
            this.GenereAddLibro.Font = new System.Drawing.Font("GROBOLD", 10F);
            this.GenereAddLibro.Location = new System.Drawing.Point(816, 105);
            this.GenereAddLibro.Margin = new System.Windows.Forms.Padding(2);
            this.GenereAddLibro.Name = "GenereAddLibro";
            this.GenereAddLibro.Size = new System.Drawing.Size(121, 23);
            this.GenereAddLibro.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(709, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 85;
            this.label1.Text = "GENERE";
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libro_label.Location = new System.Drawing.Point(491, 9);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(444, 58);
            this.libro_label.TabIndex = 84;
            this.libro_label.Text = "Aggiungi un libro";
            // 
            // AutoreAddLibro
            // 
            this.AutoreAddLibro.Font = new System.Drawing.Font("GROBOLD", 10F);
            this.AutoreAddLibro.Location = new System.Drawing.Point(442, 164);
            this.AutoreAddLibro.Margin = new System.Windows.Forms.Padding(2);
            this.AutoreAddLibro.Name = "AutoreAddLibro";
            this.AutoreAddLibro.Size = new System.Drawing.Size(237, 23);
            this.AutoreAddLibro.TabIndex = 83;
            // 
            // TitoloAddLibro
            // 
            this.TitoloAddLibro.Font = new System.Drawing.Font("GROBOLD", 10F);
            this.TitoloAddLibro.Location = new System.Drawing.Point(439, 105);
            this.TitoloAddLibro.Margin = new System.Windows.Forms.Padding(2);
            this.TitoloAddLibro.Name = "TitoloAddLibro";
            this.TitoloAddLibro.Size = new System.Drawing.Size(237, 23);
            this.TitoloAddLibro.TabIndex = 82;
            // 
            // cognome_label
            // 
            this.cognome_label.AutoSize = true;
            this.cognome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.cognome_label.Location = new System.Drawing.Point(337, 162);
            this.cognome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cognome_label.Name = "cognome_label";
            this.cognome_label.Size = new System.Drawing.Size(98, 25);
            this.cognome_label.TabIndex = 81;
            this.cognome_label.Text = "AUTORE";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.nome_label.Location = new System.Drawing.Point(349, 105);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(86, 25);
            this.nome_label.TabIndex = 80;
            this.nome_label.Text = "TITOLO";
            // 
            // Libri_pic
            // 
            this.Libri_pic.Location = new System.Drawing.Point(140, 278);
            this.Libri_pic.Name = "Libri_pic";
            this.Libri_pic.Size = new System.Drawing.Size(350, 350);
            this.Libri_pic.TabIndex = 96;
            this.Libri_pic.TabStop = false;
            // 
            // Libri
            // 
            this.Libri.AllowUserToAddRows = false;
            this.Libri.AllowUserToDeleteRows = false;
            this.Libri.AllowUserToOrderColumns = true;
            this.Libri.AutoGenerateColumns = false;
            this.Libri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Libri.Location = new System.Drawing.Point(509, 278);
            this.Libri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titoloDataGridViewTextBoxColumn,
            this.autoreDataGridViewTextBoxColumn,
            this.genereDataGridViewTextBoxColumn,
            this.prestitoDataGridViewCheckBoxColumn});
            this.Libri.DataSource = this.bsLibri;
            this.Libri.Margin = new System.Windows.Forms.Padding(2);
            this.Libri.Name = "Libri";
            this.Libri.ReadOnly = true;
            this.Libri.RowHeadersWidth = 62;
            this.Libri.RowTemplate.Height = 28;
            this.Libri.Size = new System.Drawing.Size(690, 350);
            this.Libri.TabIndex = 97;
            // 
            // bsLibri
            // 
            this.bsLibri.DataSource = typeof(Classi.Libro);
            // 
            // titoloDataGridViewTextBoxColumn
            // 
            this.titoloDataGridViewTextBoxColumn.DataPropertyName = "Titolo";
            this.titoloDataGridViewTextBoxColumn.HeaderText = "Titolo";
            this.titoloDataGridViewTextBoxColumn.Name = "titoloDataGridViewTextBoxColumn";
            this.titoloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autoreDataGridViewTextBoxColumn
            // 
            this.autoreDataGridViewTextBoxColumn.DataPropertyName = "Autore";
            this.autoreDataGridViewTextBoxColumn.HeaderText = "Autore";
            this.autoreDataGridViewTextBoxColumn.Name = "autoreDataGridViewTextBoxColumn";
            this.autoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genereDataGridViewTextBoxColumn
            // 
            this.genereDataGridViewTextBoxColumn.DataPropertyName = "Genere";
            this.genereDataGridViewTextBoxColumn.HeaderText = "Genere";
            this.genereDataGridViewTextBoxColumn.Name = "genereDataGridViewTextBoxColumn";
            this.genereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prestitoDataGridViewCheckBoxColumn
            // 
            this.prestitoDataGridViewCheckBoxColumn.DataPropertyName = "Prestito";
            this.prestitoDataGridViewCheckBoxColumn.HeaderText = "Prestito";
            this.prestitoDataGridViewCheckBoxColumn.Name = "prestitoDataGridViewCheckBoxColumn";
            this.prestitoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // AggiungiLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Libri);
            this.Controls.Add(this.Libri_pic);
            this.Controls.Add(this.AnnullaModificaLibro);
            this.Controls.Add(this.ConfermaModificaLibro);
            this.Controls.Add(this.AiutoModificaLibro);
            this.Controls.Add(this.InserisciFotoLibro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodiceAddLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenereAddLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libro_label);
            this.Controls.Add(this.AutoreAddLibro);
            this.Controls.Add(this.TitoloAddLibro);
            this.Controls.Add(this.cognome_label);
            this.Controls.Add(this.nome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AggiungiLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AggiungiLibro";
            this.Load += new System.EventHandler(this.AggiungiLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Libri_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnnullaModificaLibro;
        private System.Windows.Forms.Button ConfermaModificaLibro;
        private System.Windows.Forms.Button AiutoModificaLibro;
        private System.Windows.Forms.Button InserisciFotoLibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodiceAddLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GenereAddLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.TextBox AutoreAddLibro;
        private System.Windows.Forms.TextBox TitoloAddLibro;
        private System.Windows.Forms.Label cognome_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.PictureBox Libri_pic;
        private System.Windows.Forms.DataGridView Libri;
        private System.Windows.Forms.BindingSource bsLibri;
        private System.Windows.Forms.DataGridViewTextBoxColumn titoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prestitoDataGridViewCheckBoxColumn;
    }
}