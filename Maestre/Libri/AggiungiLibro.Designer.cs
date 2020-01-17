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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.libro_label = new System.Windows.Forms.Label();
            this.AutoreAddLibro = new System.Windows.Forms.TextBox();
            this.TitoloAddLibro = new System.Windows.Forms.TextBox();
            this.cognome_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.Libri = new System.Windows.Forms.DataGridView();
            this.titoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestitoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsLibri = new System.Windows.Forms.BindingSource(this.components);
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.genereCB = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.labeltitolo = new System.Windows.Forms.Label();
            this.titolo_tb = new System.Windows.Forms.TextBox();
            this.autore_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.genereCB_2 = new System.Windows.Forms.ComboBox();
            this.search_button = new System.Windows.Forms.Button();
            this.Libri_pic = new System.Windows.Forms.PictureBox();
            this.AnnullaModificaLibro = new System.Windows.Forms.Button();
            this.ConfermaModificaLibro = new System.Windows.Forms.Button();
            this.AiutoModificaLibro = new System.Windows.Forms.Button();
            this.InserisciFotoLibro = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Libri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libri_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(421, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "FOTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(874, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 85;
            this.label1.Text = "GENERE";
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.BackColor = System.Drawing.Color.Transparent;
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
            this.AutoreAddLibro.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.AutoreAddLibro.Location = new System.Drawing.Point(493, 164);
            this.AutoreAddLibro.Margin = new System.Windows.Forms.Padding(2);
            this.AutoreAddLibro.Name = "AutoreAddLibro";
            this.AutoreAddLibro.Size = new System.Drawing.Size(333, 30);
            this.AutoreAddLibro.TabIndex = 83;
            // 
            // TitoloAddLibro
            // 
            this.TitoloAddLibro.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.TitoloAddLibro.Location = new System.Drawing.Point(492, 105);
            this.TitoloAddLibro.Margin = new System.Windows.Forms.Padding(2);
            this.TitoloAddLibro.Name = "TitoloAddLibro";
            this.TitoloAddLibro.Size = new System.Drawing.Size(334, 30);
            this.TitoloAddLibro.TabIndex = 82;
            // 
            // cognome_label
            // 
            this.cognome_label.AutoSize = true;
            this.cognome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.cognome_label.Location = new System.Drawing.Point(385, 162);
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
            this.nome_label.Location = new System.Drawing.Point(397, 105);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(86, 25);
            this.nome_label.TabIndex = 80;
            this.nome_label.Text = "TITOLO";
            // 
            // Libri
            // 
            this.Libri.AllowUserToAddRows = false;
            this.Libri.AllowUserToDeleteRows = false;
            this.Libri.AllowUserToOrderColumns = true;
            this.Libri.AllowUserToResizeColumns = false;
            this.Libri.AllowUserToResizeRows = false;
            this.Libri.AutoGenerateColumns = false;
            this.Libri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Libri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Libri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titoloDataGridViewTextBoxColumn,
            this.autoreDataGridViewTextBoxColumn,
            this.genereDataGridViewTextBoxColumn,
            this.prestitoDataGridViewCheckBoxColumn});
            this.Libri.DataSource = this.bsLibri;
            this.Libri.Location = new System.Drawing.Point(410, 281);
            this.Libri.Margin = new System.Windows.Forms.Padding(2);
            this.Libri.MultiSelect = false;
            this.Libri.Name = "Libri";
            this.Libri.ReadOnly = true;
            this.Libri.RowHeadersVisible = false;
            this.Libri.RowHeadersWidth = 62;
            this.Libri.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Libri.RowTemplate.Height = 28;
            this.Libri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Libri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Libri.Size = new System.Drawing.Size(945, 350);
            this.Libri.TabIndex = 97;
            this.Libri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Libri_CellContentClick);
            this.Libri.SelectionChanged += new System.EventHandler(this.Libri_SelectionChanged);
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
            this.genereDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.genereDataGridViewTextBoxColumn.DataPropertyName = "Genere";
            this.genereDataGridViewTextBoxColumn.HeaderText = "Genere";
            this.genereDataGridViewTextBoxColumn.Name = "genereDataGridViewTextBoxColumn";
            this.genereDataGridViewTextBoxColumn.ReadOnly = true;
            this.genereDataGridViewTextBoxColumn.Width = 67;
            // 
            // prestitoDataGridViewCheckBoxColumn
            // 
            this.prestitoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.prestitoDataGridViewCheckBoxColumn.DataPropertyName = "Prestito";
            this.prestitoDataGridViewCheckBoxColumn.HeaderText = "Prestito";
            this.prestitoDataGridViewCheckBoxColumn.Name = "prestitoDataGridViewCheckBoxColumn";
            this.prestitoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.prestitoDataGridViewCheckBoxColumn.Width = 48;
            // 
            // bsLibri
            // 
            this.bsLibri.DataSource = typeof(Classi.Libro);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // genereCB
            // 
            this.genereCB.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.genereCB.FormattingEnabled = true;
            this.genereCB.Location = new System.Drawing.Point(986, 103);
            this.genereCB.Name = "genereCB";
            this.genereCB.Size = new System.Drawing.Size(331, 31);
            this.genereCB.TabIndex = 98;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("GROBOLD", 20F);
            this.label.Location = new System.Drawing.Point(12, 271);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(205, 33);
            this.label.TabIndex = 99;
            this.label.Text = "Cerca un libro:";
            // 
            // labeltitolo
            // 
            this.labeltitolo.AutoSize = true;
            this.labeltitolo.BackColor = System.Drawing.Color.Transparent;
            this.labeltitolo.Font = new System.Drawing.Font("GROBOLD", 16F);
            this.labeltitolo.Location = new System.Drawing.Point(14, 311);
            this.labeltitolo.Name = "labeltitolo";
            this.labeltitolo.Size = new System.Drawing.Size(77, 27);
            this.labeltitolo.TabIndex = 100;
            this.labeltitolo.Text = "Titolo:";
            // 
            // titolo_tb
            // 
            this.titolo_tb.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.titolo_tb.Location = new System.Drawing.Point(18, 341);
            this.titolo_tb.Name = "titolo_tb";
            this.titolo_tb.Size = new System.Drawing.Size(362, 30);
            this.titolo_tb.TabIndex = 101;
            this.titolo_tb.TextChanged += new System.EventHandler(this.titolo_tb_TextChanged);
            // 
            // autore_tb
            // 
            this.autore_tb.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.autore_tb.Location = new System.Drawing.Point(18, 433);
            this.autore_tb.Name = "autore_tb";
            this.autore_tb.Size = new System.Drawing.Size(362, 30);
            this.autore_tb.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("GROBOLD", 16F);
            this.label2.Location = new System.Drawing.Point(14, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 102;
            this.label2.Text = "Autore:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("GROBOLD", 16F);
            this.label4.Location = new System.Drawing.Point(14, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 27);
            this.label4.TabIndex = 105;
            this.label4.Text = "Genere:";
            // 
            // update
            // 
            this.update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // genereCB_2
            // 
            this.genereCB_2.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.genereCB_2.FormattingEnabled = true;
            this.genereCB_2.Location = new System.Drawing.Point(19, 525);
            this.genereCB_2.Name = "genereCB_2";
            this.genereCB_2.Size = new System.Drawing.Size(361, 31);
            this.genereCB_2.TabIndex = 106;
            this.genereCB_2.SelectedIndexChanged += new System.EventHandler(this.genereCB_2_SelectedIndexChanged);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.Transparent;
            this.search_button.BackgroundImage = global::Maestre.Properties.Resources.cerca;
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.search_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.search_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Location = new System.Drawing.Point(200, 573);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(182, 58);
            this.search_button.TabIndex = 104;
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Libri_pic
            // 
            this.Libri_pic.BackColor = System.Drawing.Color.Transparent;
            this.Libri_pic.ErrorImage = global::Maestre.Properties.Resources.No_image;
            this.Libri_pic.Location = new System.Drawing.Point(130, 18);
            this.Libri_pic.Name = "Libri_pic";
            this.Libri_pic.Size = new System.Drawing.Size(250, 250);
            this.Libri_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Libri_pic.TabIndex = 96;
            this.Libri_pic.TabStop = false;
            // 
            // AnnullaModificaLibro
            // 
            this.AnnullaModificaLibro.BackColor = System.Drawing.Color.Transparent;
            this.AnnullaModificaLibro.BackgroundImage = global::Maestre.Properties.Resources.Annulla;
            this.AnnullaModificaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AnnullaModificaLibro.FlatAppearance.BorderSize = 0;
            this.AnnullaModificaLibro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AnnullaModificaLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnnullaModificaLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnnullaModificaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnullaModificaLibro.Location = new System.Drawing.Point(493, 636);
            this.AnnullaModificaLibro.Name = "AnnullaModificaLibro";
            this.AnnullaModificaLibro.Size = new System.Drawing.Size(380, 120);
            this.AnnullaModificaLibro.TabIndex = 95;
            this.AnnullaModificaLibro.UseVisualStyleBackColor = false;
            this.AnnullaModificaLibro.Click += new System.EventHandler(this.AnnullaModificaLibro_Click);
            // 
            // ConfermaModificaLibro
            // 
            this.ConfermaModificaLibro.BackColor = System.Drawing.Color.Transparent;
            this.ConfermaModificaLibro.BackgroundImage = global::Maestre.Properties.Resources.Aggiungi;
            this.ConfermaModificaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfermaModificaLibro.FlatAppearance.BorderSize = 0;
            this.ConfermaModificaLibro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ConfermaModificaLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ConfermaModificaLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ConfermaModificaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfermaModificaLibro.Location = new System.Drawing.Point(990, 190);
            this.ConfermaModificaLibro.Name = "ConfermaModificaLibro";
            this.ConfermaModificaLibro.Size = new System.Drawing.Size(246, 78);
            this.ConfermaModificaLibro.TabIndex = 94;
            this.ConfermaModificaLibro.UseVisualStyleBackColor = false;
            this.ConfermaModificaLibro.Click += new System.EventHandler(this.ConfermaModificaLibro_Click);
            // 
            // AiutoModificaLibro
            // 
            this.AiutoModificaLibro.BackColor = System.Drawing.Color.Transparent;
            this.AiutoModificaLibro.BackgroundImage = global::Maestre.Properties.Resources.Aiuto;
            this.AiutoModificaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AiutoModificaLibro.FlatAppearance.BorderSize = 0;
            this.AiutoModificaLibro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AiutoModificaLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AiutoModificaLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AiutoModificaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiutoModificaLibro.Location = new System.Drawing.Point(1274, 9);
            this.AiutoModificaLibro.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoModificaLibro.Name = "AiutoModificaLibro";
            this.AiutoModificaLibro.Size = new System.Drawing.Size(81, 86);
            this.AiutoModificaLibro.TabIndex = 93;
            this.AiutoModificaLibro.UseVisualStyleBackColor = false;
            this.AiutoModificaLibro.Click += new System.EventHandler(this.AiutoModificaLibro_Click);
            // 
            // InserisciFotoLibro
            // 
            this.InserisciFotoLibro.BackColor = System.Drawing.Color.Transparent;
            this.InserisciFotoLibro.BackgroundImage = global::Maestre.Properties.Resources.Inserisci_foto;
            this.InserisciFotoLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InserisciFotoLibro.FlatAppearance.BorderSize = 0;
            this.InserisciFotoLibro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.InserisciFotoLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.InserisciFotoLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.InserisciFotoLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InserisciFotoLibro.Location = new System.Drawing.Point(492, 207);
            this.InserisciFotoLibro.Margin = new System.Windows.Forms.Padding(2);
            this.InserisciFotoLibro.Name = "InserisciFotoLibro";
            this.InserisciFotoLibro.Size = new System.Drawing.Size(130, 45);
            this.InserisciFotoLibro.TabIndex = 92;
            this.InserisciFotoLibro.UseVisualStyleBackColor = false;
            this.InserisciFotoLibro.Click += new System.EventHandler(this.InserisciFotoLibro_Click);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.Transparent;
            this.reset_button.BackgroundImage = global::Maestre.Properties.Resources.reset;
            this.reset_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reset_button.FlatAppearance.BorderSize = 0;
            this.reset_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.reset_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reset_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_button.Location = new System.Drawing.Point(12, 573);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(182, 58);
            this.reset_button.TabIndex = 107;
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // AggiungiLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maestre.Properties.Resources.Sfondo_maestre;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.genereCB_2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.autore_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titolo_tb);
            this.Controls.Add(this.labeltitolo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.genereCB);
            this.Controls.Add(this.Libri);
            this.Controls.Add(this.Libri_pic);
            this.Controls.Add(this.AnnullaModificaLibro);
            this.Controls.Add(this.ConfermaModificaLibro);
            this.Controls.Add(this.AiutoModificaLibro);
            this.Controls.Add(this.InserisciFotoLibro);
            this.Controls.Add(this.label3);
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
            ((System.ComponentModel.ISupportInitialize)(this.Libri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libri_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnnullaModificaLibro;
        private System.Windows.Forms.Button ConfermaModificaLibro;
        private System.Windows.Forms.Button AiutoModificaLibro;
        private System.Windows.Forms.Button InserisciFotoLibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.TextBox AutoreAddLibro;
        private System.Windows.Forms.TextBox TitoloAddLibro;
        private System.Windows.Forms.Label cognome_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.PictureBox Libri_pic;
        private System.Windows.Forms.DataGridView Libri;
        private System.Windows.Forms.BindingSource bsLibri;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.ComboBox genereCB;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labeltitolo;
        private System.Windows.Forms.TextBox titolo_tb;
        private System.Windows.Forms.TextBox autore_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.ComboBox genereCB_2;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn titoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prestitoDataGridViewCheckBoxColumn;
    }
}