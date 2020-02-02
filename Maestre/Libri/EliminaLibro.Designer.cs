namespace Maestre.Libri
{
    partial class EliminaLibro
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
            this.libro_label = new System.Windows.Forms.Label();
            this.ElencoLibri = new System.Windows.Forms.DataGridView();
            this.titoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLibri = new System.Windows.Forms.BindingSource(this.components);
            this.titolo_tb = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.autore_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Genere_CB = new System.Windows.Forms.ComboBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.UpdateDATA = new System.Windows.Forms.Timer(this.components);
            this.cerca_button = new System.Windows.Forms.Button();
            this.AiutoAggiungiLibro = new System.Windows.Forms.Button();
            this.Libri_pic = new System.Windows.Forms.PictureBox();
            this.AnnullaEliminaLibro = new System.Windows.Forms.Button();
            this.ConfermaEliminaLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ElencoLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libri_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.BackColor = System.Drawing.Color.Transparent;
            this.libro_label.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold);
            this.libro_label.Location = new System.Drawing.Point(481, 11);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(407, 58);
            this.libro_label.TabIndex = 68;
            this.libro_label.Text = "Elimina un libro";
            this.libro_label.Click += new System.EventHandler(this.Libro_label_Click);
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
            this.genereDataGridViewTextBoxColumn});
            this.ElencoLibri.DataSource = this.bsLibri;
            this.ElencoLibri.Location = new System.Drawing.Point(396, 240);
            this.ElencoLibri.Margin = new System.Windows.Forms.Padding(2);
            this.ElencoLibri.Name = "ElencoLibri";
            this.ElencoLibri.ReadOnly = true;
            this.ElencoLibri.RowHeadersVisible = false;
            this.ElencoLibri.RowHeadersWidth = 62;
            this.ElencoLibri.RowTemplate.Height = 28;
            this.ElencoLibri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ElencoLibri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ElencoLibri.Size = new System.Drawing.Size(959, 350);
            this.ElencoLibri.TabIndex = 69;
            this.ElencoLibri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ElencoLibri_CellClick);
            this.ElencoLibri.SelectionChanged += new System.EventHandler(this.ElencoLibri_SelectionChanged);
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
            this.autoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.autoreDataGridViewTextBoxColumn.DataPropertyName = "Autore";
            this.autoreDataGridViewTextBoxColumn.HeaderText = "Autore";
            this.autoreDataGridViewTextBoxColumn.Name = "autoreDataGridViewTextBoxColumn";
            this.autoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.autoreDataGridViewTextBoxColumn.Width = 63;
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
            // bsLibri
            // 
            this.bsLibri.DataSource = typeof(Classi.Libro);
            // 
            // titolo_tb
            // 
            this.titolo_tb.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.titolo_tb.Location = new System.Drawing.Point(552, 92);
            this.titolo_tb.Margin = new System.Windows.Forms.Padding(2);
            this.titolo_tb.Name = "titolo_tb";
            this.titolo_tb.Size = new System.Drawing.Size(350, 30);
            this.titolo_tb.TabIndex = 71;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.nome_label.Location = new System.Drawing.Point(372, 97);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(170, 25);
            this.nome_label.TabIndex = 70;
            this.nome_label.Text = "CERCA TITOLO";
            this.nome_label.Click += new System.EventHandler(this.Nome_label_Click);
            // 
            // autore_tb
            // 
            this.autore_tb.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.autore_tb.Location = new System.Drawing.Point(552, 137);
            this.autore_tb.Margin = new System.Windows.Forms.Padding(2);
            this.autore_tb.Name = "autore_tb";
            this.autore_tb.Size = new System.Drawing.Size(350, 30);
            this.autore_tb.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 132;
            this.label1.Text = "CERCA AUTORE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 134;
            this.label2.Text = "CERCA GENERE";
            // 
            // Genere_CB
            // 
            this.Genere_CB.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.Genere_CB.FormattingEnabled = true;
            this.Genere_CB.Location = new System.Drawing.Point(552, 184);
            this.Genere_CB.Name = "Genere_CB";
            this.Genere_CB.Size = new System.Drawing.Size(350, 31);
            this.Genere_CB.TabIndex = 135;
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.Transparent;
            this.reset_button.BackgroundImage = global::Maestre.Properties.Resources.reset;
            this.reset_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reset_button.FlatAppearance.BorderSize = 0;
            this.reset_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reset_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_button.Location = new System.Drawing.Point(908, 161);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(181, 56);
            this.reset_button.TabIndex = 136;
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // UpdateDATA
            // 
            this.UpdateDATA.Enabled = true;
            this.UpdateDATA.Tick += new System.EventHandler(this.UpdateDATA_Tick);
            // 
            // cerca_button
            // 
            this.cerca_button.BackColor = System.Drawing.Color.Transparent;
            this.cerca_button.BackgroundImage = global::Maestre.Properties.Resources.cerca;
            this.cerca_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cerca_button.FlatAppearance.BorderSize = 0;
            this.cerca_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cerca_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cerca_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerca_button.Location = new System.Drawing.Point(908, 84);
            this.cerca_button.Name = "cerca_button";
            this.cerca_button.Size = new System.Drawing.Size(181, 56);
            this.cerca_button.TabIndex = 131;
            this.cerca_button.UseVisualStyleBackColor = false;
            this.cerca_button.Click += new System.EventHandler(this.Cerca_button_Click);
            // 
            // AiutoAggiungiLibro
            // 
            this.AiutoAggiungiLibro.BackColor = System.Drawing.Color.Transparent;
            this.AiutoAggiungiLibro.BackgroundImage = global::Maestre.Properties.Resources.Aiuto;
            this.AiutoAggiungiLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AiutoAggiungiLibro.FlatAppearance.BorderSize = 0;
            this.AiutoAggiungiLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiutoAggiungiLibro.Location = new System.Drawing.Point(1235, 11);
            this.AiutoAggiungiLibro.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoAggiungiLibro.Name = "AiutoAggiungiLibro";
            this.AiutoAggiungiLibro.Size = new System.Drawing.Size(120, 120);
            this.AiutoAggiungiLibro.TabIndex = 99;
            this.AiutoAggiungiLibro.UseVisualStyleBackColor = false;
            this.AiutoAggiungiLibro.Click += new System.EventHandler(this.AiutoAggiungiLibro_Click);
            // 
            // Libri_pic
            // 
            this.Libri_pic.BackColor = System.Drawing.Color.Transparent;
            this.Libri_pic.ErrorImage = global::Maestre.Properties.Resources.No_image;
            this.Libri_pic.InitialImage = null;
            this.Libri_pic.Location = new System.Drawing.Point(41, 240);
            this.Libri_pic.Name = "Libri_pic";
            this.Libri_pic.Size = new System.Drawing.Size(350, 350);
            this.Libri_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Libri_pic.TabIndex = 98;
            this.Libri_pic.TabStop = false;
            this.Libri_pic.Click += new System.EventHandler(this.Libri_pic_Click);
            // 
            // AnnullaEliminaLibro
            // 
            this.AnnullaEliminaLibro.BackColor = System.Drawing.Color.Transparent;
            this.AnnullaEliminaLibro.BackgroundImage = global::Maestre.Properties.Resources.Annulla;
            this.AnnullaEliminaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AnnullaEliminaLibro.FlatAppearance.BorderSize = 0;
            this.AnnullaEliminaLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnnullaEliminaLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnnullaEliminaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnullaEliminaLibro.Location = new System.Drawing.Point(229, 636);
            this.AnnullaEliminaLibro.Name = "AnnullaEliminaLibro";
            this.AnnullaEliminaLibro.Size = new System.Drawing.Size(380, 120);
            this.AnnullaEliminaLibro.TabIndex = 73;
            this.AnnullaEliminaLibro.UseVisualStyleBackColor = false;
            this.AnnullaEliminaLibro.Click += new System.EventHandler(this.AnnullaEliminaLibro_Click);
            // 
            // ConfermaEliminaLibro
            // 
            this.ConfermaEliminaLibro.BackColor = System.Drawing.Color.Transparent;
            this.ConfermaEliminaLibro.BackgroundImage = global::Maestre.Properties.Resources.Conferma;
            this.ConfermaEliminaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfermaEliminaLibro.FlatAppearance.BorderSize = 0;
            this.ConfermaEliminaLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ConfermaEliminaLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ConfermaEliminaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfermaEliminaLibro.Location = new System.Drawing.Point(758, 637);
            this.ConfermaEliminaLibro.Name = "ConfermaEliminaLibro";
            this.ConfermaEliminaLibro.Size = new System.Drawing.Size(380, 120);
            this.ConfermaEliminaLibro.TabIndex = 72;
            this.ConfermaEliminaLibro.UseVisualStyleBackColor = false;
            this.ConfermaEliminaLibro.Click += new System.EventHandler(this.ConfermaEliminaLibro_Click);
            // 
            // EliminaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maestre.Properties.Resources.Sfondo_maestre;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.Genere_CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autore_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cerca_button);
            this.Controls.Add(this.AiutoAggiungiLibro);
            this.Controls.Add(this.Libri_pic);
            this.Controls.Add(this.AnnullaEliminaLibro);
            this.Controls.Add(this.ConfermaEliminaLibro);
            this.Controls.Add(this.titolo_tb);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.ElencoLibri);
            this.Controls.Add(this.libro_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminaLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminaLibro";
            this.Load += new System.EventHandler(this.EliminaLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ElencoLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libri_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.DataGridView ElencoLibri;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Button ConfermaEliminaLibro;
        private System.Windows.Forms.Button AnnullaEliminaLibro;
        private System.Windows.Forms.PictureBox Libri_pic;
        private System.Windows.Forms.Button AiutoAggiungiLibro;
        private System.Windows.Forms.Button cerca_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genereDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsLibri;
        private System.Windows.Forms.ComboBox Genere_CB;
        private System.Windows.Forms.Button reset_button;
        public System.Windows.Forms.TextBox titolo_tb;
        private System.Windows.Forms.TextBox autore_tb;
        public System.Windows.Forms.Timer UpdateDATA;
    }
}