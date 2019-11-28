namespace Maestre.Statistiche_WIP_
{
    partial class NumeroDiVolteLetti
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
            this.label1 = new System.Windows.Forms.Label();
            this.Indietro_Button = new System.Windows.Forms.Button();
            this.BambiniLettoIlLibro = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLibri = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Libro_pic = new System.Windows.Forms.PictureBox();
            this.TitoloLibroScelto = new System.Windows.Forms.Label();
            this.AutoreLibroScelto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NLibroletto = new System.Windows.Forms.Label();
            this.GenerelibroScelto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BambiniLettoIlLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libro_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(971, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quante volte il libro scelto è stato letto";
            // 
            // Indietro_Button
            // 
            this.Indietro_Button.BackColor = System.Drawing.Color.Transparent;
            this.Indietro_Button.BackgroundImage = global::Maestre.Properties.Resources.Indietro;
            this.Indietro_Button.FlatAppearance.BorderSize = 0;
            this.Indietro_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Indietro_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Indietro_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Indietro_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Indietro_Button.Location = new System.Drawing.Point(489, 636);
            this.Indietro_Button.Name = "Indietro_Button";
            this.Indietro_Button.Size = new System.Drawing.Size(380, 120);
            this.Indietro_Button.TabIndex = 1;
            this.Indietro_Button.UseVisualStyleBackColor = false;
            this.Indietro_Button.Click += new System.EventHandler(this.Indietro_Button_Click);
            // 
            // BambiniLettoIlLibro
            // 
            this.BambiniLettoIlLibro.AllowUserToAddRows = false;
            this.BambiniLettoIlLibro.AllowUserToDeleteRows = false;
            this.BambiniLettoIlLibro.AllowUserToOrderColumns = true;
            this.BambiniLettoIlLibro.AllowUserToResizeColumns = false;
            this.BambiniLettoIlLibro.AllowUserToResizeRows = false;
            this.BambiniLettoIlLibro.AutoGenerateColumns = false;
            this.BambiniLettoIlLibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BambiniLettoIlLibro.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.BambiniLettoIlLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BambiniLettoIlLibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn});
            this.BambiniLettoIlLibro.DataSource = this.bsLibri;
            this.BambiniLettoIlLibro.Location = new System.Drawing.Point(11, 287);
            this.BambiniLettoIlLibro.Margin = new System.Windows.Forms.Padding(2);
            this.BambiniLettoIlLibro.MultiSelect = false;
            this.BambiniLettoIlLibro.Name = "BambiniLettoIlLibro";
            this.BambiniLettoIlLibro.ReadOnly = true;
            this.BambiniLettoIlLibro.RowHeadersVisible = false;
            this.BambiniLettoIlLibro.RowHeadersWidth = 62;
            this.BambiniLettoIlLibro.RowTemplate.Height = 28;
            this.BambiniLettoIlLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BambiniLettoIlLibro.Size = new System.Drawing.Size(1344, 285);
            this.BambiniLettoIlLibro.TabIndex = 132;
            this.BambiniLettoIlLibro.SelectionChanged += new System.EventHandler(this.BambiniLettoIlLibro_SelectionChanged);
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
            this.classeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            this.classeDataGridViewTextBoxColumn.ReadOnly = true;
            this.classeDataGridViewTextBoxColumn.Width = 63;
            // 
            // bsLibri
            // 
            this.bsLibri.DataSource = typeof(Classi.Bambino);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(673, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 133;
            this.label2.Text = "AUTORE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(685, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 134;
            this.label3.Text = "TITOLO:";
            // 
            // Libro_pic
            // 
            this.Libro_pic.BackColor = System.Drawing.Color.Transparent;
            this.Libro_pic.ErrorImage = global::Maestre.Properties.Resources.No_image;
            this.Libro_pic.Location = new System.Drawing.Point(431, 82);
            this.Libro_pic.Name = "Libro_pic";
            this.Libro_pic.Size = new System.Drawing.Size(200, 200);
            this.Libro_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Libro_pic.TabIndex = 135;
            this.Libro_pic.TabStop = false;
            // 
            // TitoloLibroScelto
            // 
            this.TitoloLibroScelto.AutoSize = true;
            this.TitoloLibroScelto.BackColor = System.Drawing.Color.Transparent;
            this.TitoloLibroScelto.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.TitoloLibroScelto.Location = new System.Drawing.Point(770, 129);
            this.TitoloLibroScelto.Name = "TitoloLibroScelto";
            this.TitoloLibroScelto.Size = new System.Drawing.Size(78, 25);
            this.TitoloLibroScelto.TabIndex = 136;
            this.TitoloLibroScelto.Text = "label4";
            // 
            // AutoreLibroScelto
            // 
            this.AutoreLibroScelto.AutoSize = true;
            this.AutoreLibroScelto.BackColor = System.Drawing.Color.Transparent;
            this.AutoreLibroScelto.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.AutoreLibroScelto.Location = new System.Drawing.Point(771, 169);
            this.AutoreLibroScelto.Name = "AutoreLibroScelto";
            this.AutoreLibroScelto.Size = new System.Drawing.Size(77, 25);
            this.AutoreLibroScelto.TabIndex = 137;
            this.AutoreLibroScelto.Text = "label5";
            this.AutoreLibroScelto.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 590);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 25);
            this.label6.TabIndex = 138;
            this.label6.Text = "QUANTE VOLTE E\' STATO LETTO IL LIBRO:";
            // 
            // NLibroletto
            // 
            this.NLibroletto.AutoSize = true;
            this.NLibroletto.BackColor = System.Drawing.Color.Transparent;
            this.NLibroletto.Font = new System.Drawing.Font("GROBOLD", 14F, System.Drawing.FontStyle.Bold);
            this.NLibroletto.Location = new System.Drawing.Point(898, 590);
            this.NLibroletto.Name = "NLibroletto";
            this.NLibroletto.Size = new System.Drawing.Size(24, 23);
            this.NLibroletto.TabIndex = 139;
            this.NLibroletto.Text = "0";
            // 
            // GenerelibroScelto
            // 
            this.GenerelibroScelto.AutoSize = true;
            this.GenerelibroScelto.BackColor = System.Drawing.Color.Transparent;
            this.GenerelibroScelto.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.GenerelibroScelto.Location = new System.Drawing.Point(771, 209);
            this.GenerelibroScelto.Name = "GenerelibroScelto";
            this.GenerelibroScelto.Size = new System.Drawing.Size(77, 25);
            this.GenerelibroScelto.TabIndex = 141;
            this.GenerelibroScelto.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(673, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 140;
            this.label7.Text = "GENERE:";
            // 
            // NumeroDiVolteLetti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maestre.Properties.Resources.Sfondo_maestre;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.GenerelibroScelto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NLibroletto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AutoreLibroScelto);
            this.Controls.Add(this.TitoloLibroScelto);
            this.Controls.Add(this.Libro_pic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BambiniLettoIlLibro);
            this.Controls.Add(this.Indietro_Button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NumeroDiVolteLetti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumeroDiVolteLetti";
            this.Load += new System.EventHandler(this.NumeroDiVolteLetti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BambiniLettoIlLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libro_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Indietro_Button;
        private System.Windows.Forms.DataGridView BambiniLettoIlLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Libro_pic;
        private System.Windows.Forms.Label TitoloLibroScelto;
        private System.Windows.Forms.Label AutoreLibroScelto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsLibri;
        private System.Windows.Forms.Label NLibroletto;
        private System.Windows.Forms.Label GenerelibroScelto;
        private System.Windows.Forms.Label label7;
    }
}