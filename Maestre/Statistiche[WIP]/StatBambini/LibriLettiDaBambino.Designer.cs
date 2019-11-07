namespace Maestre.Statistiche_WIP_
{
    partial class LibriLettiDaBambino
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
            this.RicercaStatBambini = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeBambino = new System.Windows.Forms.TextBox();
            this.CognomeBambino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AiutoStatistiche = new System.Windows.Forms.Button();
            this.Indietro_Button = new System.Windows.Forms.Button();
            this.TabellaBambini = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLibri = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).BeginInit();
            this.SuspendLayout();
            // 
            // RicercaStatBambini
            // 
            this.RicercaStatBambini.BackColor = System.Drawing.Color.Transparent;
            this.RicercaStatBambini.BackgroundImage = global::Maestre.Properties.Resources.cerca;
            this.RicercaStatBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RicercaStatBambini.FlatAppearance.BorderSize = 0;
            this.RicercaStatBambini.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.RicercaStatBambini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RicercaStatBambini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RicercaStatBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RicercaStatBambini.Location = new System.Drawing.Point(720, 88);
            this.RicercaStatBambini.Name = "RicercaStatBambini";
            this.RicercaStatBambini.Size = new System.Drawing.Size(380, 120);
            this.RicercaStatBambini.TabIndex = 1;
            this.RicercaStatBambini.UseVisualStyleBackColor = false;
            this.RicercaStatBambini.Click += new System.EventHandler(this.RicercaStatBambini_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(100, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("GROBOLD", 25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "COGNOME:";
            // 
            // NomeBambino
            // 
            this.NomeBambino.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NomeBambino.Location = new System.Drawing.Point(237, 95);
            this.NomeBambino.Name = "NomeBambino";
            this.NomeBambino.Size = new System.Drawing.Size(427, 38);
            this.NomeBambino.TabIndex = 4;
            this.NomeBambino.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // CognomeBambino
            // 
            this.CognomeBambino.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CognomeBambino.Location = new System.Drawing.Point(237, 171);
            this.CognomeBambino.Name = "CognomeBambino";
            this.CognomeBambino.Size = new System.Drawing.Size(427, 38);
            this.CognomeBambino.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 58);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cerca studente";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // AiutoStatistiche
            // 
            this.AiutoStatistiche.BackColor = System.Drawing.Color.Transparent;
            this.AiutoStatistiche.BackgroundImage = global::Maestre.Properties.Resources.Aiuto;
            this.AiutoStatistiche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AiutoStatistiche.FlatAppearance.BorderSize = 0;
            this.AiutoStatistiche.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AiutoStatistiche.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AiutoStatistiche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AiutoStatistiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiutoStatistiche.Location = new System.Drawing.Point(1234, 12);
            this.AiutoStatistiche.Name = "AiutoStatistiche";
            this.AiutoStatistiche.Size = new System.Drawing.Size(120, 120);
            this.AiutoStatistiche.TabIndex = 7;
            this.AiutoStatistiche.UseVisualStyleBackColor = false;
            // 
            // Indietro_Button
            // 
            this.Indietro_Button.BackColor = System.Drawing.Color.Transparent;
            this.Indietro_Button.BackgroundImage = global::Maestre.Properties.Resources.Indietro;
            this.Indietro_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Indietro_Button.FlatAppearance.BorderSize = 0;
            this.Indietro_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Indietro_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Indietro_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Indietro_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Indietro_Button.Location = new System.Drawing.Point(5, 636);
            this.Indietro_Button.Name = "Indietro_Button";
            this.Indietro_Button.Size = new System.Drawing.Size(380, 120);
            this.Indietro_Button.TabIndex = 0;
            this.Indietro_Button.UseVisualStyleBackColor = false;
            this.Indietro_Button.Click += new System.EventHandler(this.Indietro_Button_Click);
            // 
            // TabellaBambini
            // 
            this.TabellaBambini.AllowUserToAddRows = false;
            this.TabellaBambini.AllowUserToDeleteRows = false;
            this.TabellaBambini.AllowUserToOrderColumns = true;
            this.TabellaBambini.AutoGenerateColumns = false;
            this.TabellaBambini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabellaBambini.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.TabellaBambini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaBambini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn,
            this.dataNascitaDataGridViewTextBoxColumn});
            this.TabellaBambini.DataSource = this.bsLibri;
            this.TabellaBambini.Location = new System.Drawing.Point(12, 232);
            this.TabellaBambini.Name = "TabellaBambini";
            this.TabellaBambini.ReadOnly = true;
            this.TabellaBambini.RowHeadersVisible = false;
            this.TabellaBambini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabellaBambini.Size = new System.Drawing.Size(1349, 371);
            this.TabellaBambini.TabIndex = 8;
            this.TabellaBambini.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabellaBambini_CellDoubleClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classeDataGridViewTextBoxColumn
            // 
            this.classeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            this.classeDataGridViewTextBoxColumn.ReadOnly = true;
            this.classeDataGridViewTextBoxColumn.Width = 63;
            // 
            // dataNascitaDataGridViewTextBoxColumn
            // 
            this.dataNascitaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataNascitaDataGridViewTextBoxColumn.DataPropertyName = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn.HeaderText = "Data di nascita";
            this.dataNascitaDataGridViewTextBoxColumn.Name = "dataNascitaDataGridViewTextBoxColumn";
            this.dataNascitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNascitaDataGridViewTextBoxColumn.Width = 95;
            // 
            // bsLibri
            // 
            this.bsLibri.DataSource = typeof(Classi.Bambino);
            // 
            // LibriLettiDaBambino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maestre.Properties.Resources.Sfondo_maestre;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.TabellaBambini);
            this.Controls.Add(this.AiutoStatistiche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CognomeBambino);
            this.Controls.Add(this.NomeBambino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RicercaStatBambini);
            this.Controls.Add(this.Indietro_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibriLettiDaBambino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a1";
            this.Load += new System.EventHandler(this.LibriLettiDaBambino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Indietro_Button;
        private System.Windows.Forms.Button RicercaStatBambini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeBambino;
        private System.Windows.Forms.TextBox CognomeBambino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AiutoStatistiche;
        private System.Windows.Forms.DataGridView TabellaBambini;
        private System.Windows.Forms.BindingSource bsLibri;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascitaDataGridViewTextBoxColumn;
    }
}