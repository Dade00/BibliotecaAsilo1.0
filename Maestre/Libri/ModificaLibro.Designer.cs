namespace Maestre.Libri
{
    partial class ModificaLibro
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
            this.AiutoAggiungiLibro = new System.Windows.Forms.Button();
            this.CercaFotoLibro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.libro_label = new System.Windows.Forms.Label();
            this.AutoreModLibro = new System.Windows.Forms.TextBox();
            this.TitotloModLibro = new System.Windows.Forms.TextBox();
            this.cognome_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.Libri_pic = new System.Windows.Forms.PictureBox();
            this.ElencoLibri = new System.Windows.Forms.DataGridView();
            this.titoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLibri = new System.Windows.Forms.BindingSource(this.components);
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.AnnullaModifica = new System.Windows.Forms.Button();
            this.ConfermaButton = new System.Windows.Forms.Button();
            this.genere_cb = new System.Windows.Forms.ComboBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.genereCB_2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.autore_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titolo_tb = new System.Windows.Forms.TextBox();
            this.labeltitolo = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Libri_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElencoLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).BeginInit();
            this.SuspendLayout();
            // 
            // AiutoAggiungiLibro
            // 
            this.AiutoAggiungiLibro.BackColor = System.Drawing.Color.Transparent;
            this.AiutoAggiungiLibro.BackgroundImage = global::Maestre.Properties.Resources.Aiuto;
            this.AiutoAggiungiLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AiutoAggiungiLibro.FlatAppearance.BorderSize = 0;
            this.AiutoAggiungiLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AiutoAggiungiLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AiutoAggiungiLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiutoAggiungiLibro.Location = new System.Drawing.Point(1235, 11);
            this.AiutoAggiungiLibro.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoAggiungiLibro.Name = "AiutoAggiungiLibro";
            this.AiutoAggiungiLibro.Size = new System.Drawing.Size(120, 120);
            this.AiutoAggiungiLibro.TabIndex = 77;
            this.AiutoAggiungiLibro.UseVisualStyleBackColor = false;
            this.AiutoAggiungiLibro.Click += new System.EventHandler(this.AiutoAggiungiLibro_Click);
            // 
            // CercaFotoLibro
            // 
            this.CercaFotoLibro.BackColor = System.Drawing.Color.Transparent;
            this.CercaFotoLibro.BackgroundImage = global::Maestre.Properties.Resources.Modifica_foto;
            this.CercaFotoLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CercaFotoLibro.FlatAppearance.BorderSize = 0;
            this.CercaFotoLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CercaFotoLibro.Location = new System.Drawing.Point(492, 207);
            this.CercaFotoLibro.Margin = new System.Windows.Forms.Padding(2);
            this.CercaFotoLibro.Name = "CercaFotoLibro";
            this.CercaFotoLibro.Size = new System.Drawing.Size(130, 45);
            this.CercaFotoLibro.TabIndex = 76;
            this.CercaFotoLibro.UseVisualStyleBackColor = false;
            this.CercaFotoLibro.Click += new System.EventHandler(this.CercaFotoLibro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(421, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 74;
            this.label3.Text = "FOTO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(874, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "GENERE";
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.BackColor = System.Drawing.Color.Transparent;
            this.libro_label.Font = new System.Drawing.Font("GROBOLD", 30F, System.Drawing.FontStyle.Bold);
            this.libro_label.Location = new System.Drawing.Point(504, 9);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(376, 49);
            this.libro_label.TabIndex = 68;
            this.libro_label.Text = "Modifica un libro";
            this.libro_label.Click += new System.EventHandler(this.Libro_label_Click);
            // 
            // AutoreModLibro
            // 
            this.AutoreModLibro.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.AutoreModLibro.Location = new System.Drawing.Point(493, 164);
            this.AutoreModLibro.Margin = new System.Windows.Forms.Padding(2);
            this.AutoreModLibro.Name = "AutoreModLibro";
            this.AutoreModLibro.Size = new System.Drawing.Size(333, 30);
            this.AutoreModLibro.TabIndex = 67;
            // 
            // TitotloModLibro
            // 
            this.TitotloModLibro.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.TitotloModLibro.Location = new System.Drawing.Point(492, 105);
            this.TitotloModLibro.Margin = new System.Windows.Forms.Padding(2);
            this.TitotloModLibro.Name = "TitotloModLibro";
            this.TitotloModLibro.Size = new System.Drawing.Size(334, 30);
            this.TitotloModLibro.TabIndex = 66;
            // 
            // cognome_label
            // 
            this.cognome_label.AutoSize = true;
            this.cognome_label.BackColor = System.Drawing.Color.Transparent;
            this.cognome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.cognome_label.Location = new System.Drawing.Point(385, 162);
            this.cognome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cognome_label.Name = "cognome_label";
            this.cognome_label.Size = new System.Drawing.Size(98, 25);
            this.cognome_label.TabIndex = 65;
            this.cognome_label.Text = "AUTORE";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.BackColor = System.Drawing.Color.Transparent;
            this.nome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.nome_label.Location = new System.Drawing.Point(397, 105);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(86, 25);
            this.nome_label.TabIndex = 64;
            this.nome_label.Text = "TITOLO";
            // 
            // Libri_pic
            // 
            this.Libri_pic.BackColor = System.Drawing.Color.Transparent;
            this.Libri_pic.ErrorImage = global::Maestre.Properties.Resources.No_image;
            this.Libri_pic.Location = new System.Drawing.Point(130, 18);
            this.Libri_pic.Name = "Libri_pic";
            this.Libri_pic.Size = new System.Drawing.Size(250, 250);
            this.Libri_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Libri_pic.TabIndex = 97;
            this.Libri_pic.TabStop = false;
            // 
            // ElencoLibri
            // 
            this.ElencoLibri.AllowUserToAddRows = false;
            this.ElencoLibri.AllowUserToDeleteRows = false;
            this.ElencoLibri.AllowUserToOrderColumns = true;
            this.ElencoLibri.AllowUserToResizeColumns = false;
            this.ElencoLibri.AllowUserToResizeRows = false;
            this.ElencoLibri.AutoGenerateColumns = false;
            this.ElencoLibri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ElencoLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElencoLibri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titoloDataGridViewTextBoxColumn,
            this.autoreDataGridViewTextBoxColumn,
            this.Genere});
            this.ElencoLibri.DataSource = this.bsLibri;
            this.ElencoLibri.Location = new System.Drawing.Point(410, 281);
            this.ElencoLibri.Margin = new System.Windows.Forms.Padding(2);
            this.ElencoLibri.Name = "ElencoLibri";
            this.ElencoLibri.ReadOnly = true;
            this.ElencoLibri.RowHeadersVisible = false;
            this.ElencoLibri.RowHeadersWidth = 62;
            this.ElencoLibri.RowTemplate.Height = 28;
            this.ElencoLibri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ElencoLibri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ElencoLibri.Size = new System.Drawing.Size(945, 350);
            this.ElencoLibri.TabIndex = 73;
            this.ElencoLibri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ElencoLibri_CellClick);
            this.ElencoLibri.SelectionChanged += new System.EventHandler(this.ElencoLibri_SelectionChanged);
            // 
            // titoloDataGridViewTextBoxColumn
            // 
            this.titoloDataGridViewTextBoxColumn.DataPropertyName = "Titolo";
            this.titoloDataGridViewTextBoxColumn.FillWeight = 147.7612F;
            this.titoloDataGridViewTextBoxColumn.HeaderText = "Titolo";
            this.titoloDataGridViewTextBoxColumn.Name = "titoloDataGridViewTextBoxColumn";
            this.titoloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autoreDataGridViewTextBoxColumn
            // 
            this.autoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.autoreDataGridViewTextBoxColumn.DataPropertyName = "Autore";
            this.autoreDataGridViewTextBoxColumn.HeaderText = "Autore";
            this.autoreDataGridViewTextBoxColumn.Name = "autoreDataGridViewTextBoxColumn";
            this.autoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.autoreDataGridViewTextBoxColumn.Width = 63;
            // 
            // Genere
            // 
            this.Genere.DataPropertyName = "Genere";
            this.Genere.FillWeight = 52.23881F;
            this.Genere.HeaderText = "Genere";
            this.Genere.Name = "Genere";
            this.Genere.ReadOnly = true;
            // 
            // bsLibri
            // 
            this.bsLibri.DataSource = typeof(Classi.Libro);
            this.bsLibri.Filter = "";
            // 
            // AnnullaModifica
            // 
            this.AnnullaModifica.BackColor = System.Drawing.Color.Transparent;
            this.AnnullaModifica.BackgroundImage = global::Maestre.Properties.Resources.Indietro;
            this.AnnullaModifica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AnnullaModifica.FlatAppearance.BorderSize = 0;
            this.AnnullaModifica.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AnnullaModifica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnnullaModifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnnullaModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnullaModifica.Location = new System.Drawing.Point(493, 636);
            this.AnnullaModifica.Name = "AnnullaModifica";
            this.AnnullaModifica.Size = new System.Drawing.Size(380, 120);
            this.AnnullaModifica.TabIndex = 98;
            this.AnnullaModifica.UseVisualStyleBackColor = true;
            this.AnnullaModifica.Click += new System.EventHandler(this.AnnullaModifica_Click);
            // 
            // ConfermaButton
            // 
            this.ConfermaButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfermaButton.BackgroundImage = global::Maestre.Properties.Resources.Conferma;
            this.ConfermaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfermaButton.FlatAppearance.BorderSize = 0;
            this.ConfermaButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ConfermaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ConfermaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ConfermaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfermaButton.Location = new System.Drawing.Point(990, 190);
            this.ConfermaButton.Name = "ConfermaButton";
            this.ConfermaButton.Size = new System.Drawing.Size(267, 88);
            this.ConfermaButton.TabIndex = 99;
            this.ConfermaButton.UseVisualStyleBackColor = true;
            this.ConfermaButton.Click += new System.EventHandler(this.ConfermaButton_Click);
            // 
            // genere_cb
            // 
            this.genere_cb.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.genere_cb.FormattingEnabled = true;
            this.genere_cb.Location = new System.Drawing.Point(986, 103);
            this.genere_cb.Name = "genere_cb";
            this.genere_cb.Size = new System.Drawing.Size(244, 31);
            this.genere_cb.TabIndex = 100;
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
            this.reset_button.TabIndex = 116;
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // genereCB_2
            // 
            this.genereCB_2.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.genereCB_2.FormattingEnabled = true;
            this.genereCB_2.Location = new System.Drawing.Point(19, 525);
            this.genereCB_2.Name = "genereCB_2";
            this.genereCB_2.Size = new System.Drawing.Size(361, 31);
            this.genereCB_2.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("GROBOLD", 16F);
            this.label4.Location = new System.Drawing.Point(14, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 27);
            this.label4.TabIndex = 114;
            this.label4.Text = "Genere:";
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
            this.search_button.TabIndex = 113;
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // autore_tb
            // 
            this.autore_tb.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.autore_tb.Location = new System.Drawing.Point(18, 433);
            this.autore_tb.Name = "autore_tb";
            this.autore_tb.Size = new System.Drawing.Size(362, 30);
            this.autore_tb.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("GROBOLD", 16F);
            this.label2.Location = new System.Drawing.Point(14, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 111;
            this.label2.Text = "Autore:";
            // 
            // titolo_tb
            // 
            this.titolo_tb.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.titolo_tb.Location = new System.Drawing.Point(18, 341);
            this.titolo_tb.Name = "titolo_tb";
            this.titolo_tb.Size = new System.Drawing.Size(362, 30);
            this.titolo_tb.TabIndex = 110;
            // 
            // labeltitolo
            // 
            this.labeltitolo.AutoSize = true;
            this.labeltitolo.BackColor = System.Drawing.Color.Transparent;
            this.labeltitolo.Font = new System.Drawing.Font("GROBOLD", 16F);
            this.labeltitolo.Location = new System.Drawing.Point(14, 311);
            this.labeltitolo.Name = "labeltitolo";
            this.labeltitolo.Size = new System.Drawing.Size(77, 27);
            this.labeltitolo.TabIndex = 109;
            this.labeltitolo.Text = "Titolo:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("GROBOLD", 20F);
            this.label.Location = new System.Drawing.Point(12, 271);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(205, 33);
            this.label.TabIndex = 108;
            this.label.Text = "Cerca un libro:";
            // 
            // ModificaLibro
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
            this.Controls.Add(this.genere_cb);
            this.Controls.Add(this.ConfermaButton);
            this.Controls.Add(this.AnnullaModifica);
            this.Controls.Add(this.Libri_pic);
            this.Controls.Add(this.AiutoAggiungiLibro);
            this.Controls.Add(this.CercaFotoLibro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ElencoLibri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libro_label);
            this.Controls.Add(this.AutoreModLibro);
            this.Controls.Add(this.TitotloModLibro);
            this.Controls.Add(this.cognome_label);
            this.Controls.Add(this.nome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificaLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificaLibro";
            this.Load += new System.EventHandler(this.ModificaLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Libri_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElencoLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AiutoAggiungiLibro;
        private System.Windows.Forms.Button CercaFotoLibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.TextBox AutoreModLibro;
        private System.Windows.Forms.TextBox TitotloModLibro;
        private System.Windows.Forms.Label cognome_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Button ConfermaModificaLibro;
        private System.Windows.Forms.Button AnnullaModificaLibro;
        private System.Windows.Forms.PictureBox Libri_pic;
        private System.Windows.Forms.DataGridView ElencoLibri;
        private System.Windows.Forms.BindingSource bsLibri;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Button AnnullaModifica;
        private System.Windows.Forms.Button ConfermaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn genereDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox genere_cb;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.ComboBox genereCB_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox autore_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titolo_tb;
        private System.Windows.Forms.Label labeltitolo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridViewTextBoxColumn titoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genere;
    }
}