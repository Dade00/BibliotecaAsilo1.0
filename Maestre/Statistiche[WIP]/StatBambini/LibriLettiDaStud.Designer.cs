namespace Maestre.Statistiche_WIP_
{
    partial class LibriLetti
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
            this.TabellaBambini = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClasseStudScelto = new System.Windows.Forms.Label();
            this.CogomeStudScelto = new System.Windows.Forms.Label();
            this.NomeStudScelto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NLibriLabel = new System.Windows.Forms.Label();
            this.Indietro_button = new System.Windows.Forms.Button();
            this.Bambini_pic = new System.Windows.Forms.PictureBox();
            this.titoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLibri = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).BeginInit();
            this.SuspendLayout();
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
            this.TabellaBambini.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.TabellaBambini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaBambini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titoloDataGridViewTextBoxColumn,
            this.autoreDataGridViewTextBoxColumn,
            this.genereDataGridViewTextBoxColumn});
            this.TabellaBambini.DataSource = this.bsLibri;
            this.TabellaBambini.Location = new System.Drawing.Point(11, 293);
            this.TabellaBambini.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaBambini.MultiSelect = false;
            this.TabellaBambini.Name = "TabellaBambini";
            this.TabellaBambini.ReadOnly = true;
            this.TabellaBambini.RowHeadersVisible = false;
            this.TabellaBambini.RowHeadersWidth = 62;
            this.TabellaBambini.RowTemplate.Height = 28;
            this.TabellaBambini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabellaBambini.Size = new System.Drawing.Size(1344, 268);
            this.TabellaBambini.TabIndex = 131;
            this.TabellaBambini.SelectionChanged += new System.EventHandler(this.TabellaBambini_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(471, 573);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 33);
            this.label1.TabIndex = 133;
            this.label1.Text = "TOTALE LIBRI LETTI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(617, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 135;
            this.label2.Text = "NOME:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(565, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 136;
            this.label3.Text = "COGNOME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(596, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 137;
            this.label4.Text = "CLASSE:";
            // 
            // ClasseStudScelto
            // 
            this.ClasseStudScelto.AutoSize = true;
            this.ClasseStudScelto.BackColor = System.Drawing.Color.Transparent;
            this.ClasseStudScelto.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.ClasseStudScelto.Location = new System.Drawing.Point(704, 199);
            this.ClasseStudScelto.Name = "ClasseStudScelto";
            this.ClasseStudScelto.Size = new System.Drawing.Size(67, 23);
            this.ClasseStudScelto.TabIndex = 138;
            this.ClasseStudScelto.Text = "label5";
            // 
            // CogomeStudScelto
            // 
            this.CogomeStudScelto.AutoSize = true;
            this.CogomeStudScelto.BackColor = System.Drawing.Color.Transparent;
            this.CogomeStudScelto.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.CogomeStudScelto.Location = new System.Drawing.Point(704, 163);
            this.CogomeStudScelto.Name = "CogomeStudScelto";
            this.CogomeStudScelto.Size = new System.Drawing.Size(67, 23);
            this.CogomeStudScelto.TabIndex = 139;
            this.CogomeStudScelto.Text = "label6";
            // 
            // NomeStudScelto
            // 
            this.NomeStudScelto.AutoSize = true;
            this.NomeStudScelto.BackColor = System.Drawing.Color.Transparent;
            this.NomeStudScelto.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.NomeStudScelto.Location = new System.Drawing.Point(704, 124);
            this.NomeStudScelto.Name = "NomeStudScelto";
            this.NomeStudScelto.Size = new System.Drawing.Size(66, 23);
            this.NomeStudScelto.TabIndex = 140;
            this.NomeStudScelto.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(300, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(785, 58);
            this.label8.TabIndex = 143;
            this.label8.Text = "Quanti libri ha letto lo studente";
            // 
            // NLibriLabel
            // 
            this.NLibriLabel.AutoSize = true;
            this.NLibriLabel.BackColor = System.Drawing.Color.Transparent;
            this.NLibriLabel.Font = new System.Drawing.Font("GROBOLD", 20F);
            this.NLibriLabel.Location = new System.Drawing.Point(776, 573);
            this.NLibriLabel.Name = "NLibriLabel";
            this.NLibriLabel.Size = new System.Drawing.Size(33, 33);
            this.NLibriLabel.TabIndex = 144;
            this.NLibriLabel.Text = "0";
            // 
            // Indietro_button
            // 
            this.Indietro_button.BackColor = System.Drawing.Color.Transparent;
            this.Indietro_button.BackgroundImage = global::Maestre.Properties.Resources.Indietro;
            this.Indietro_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Indietro_button.FlatAppearance.BorderSize = 0;
            this.Indietro_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Indietro_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Indietro_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Indietro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Indietro_button.Location = new System.Drawing.Point(445, 636);
            this.Indietro_button.Name = "Indietro_button";
            this.Indietro_button.Size = new System.Drawing.Size(380, 120);
            this.Indietro_button.TabIndex = 141;
            this.Indietro_button.UseVisualStyleBackColor = false;
            this.Indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            // 
            // Bambini_pic
            // 
            this.Bambini_pic.BackColor = System.Drawing.Color.Transparent;
            this.Bambini_pic.BackgroundImage = global::Maestre.Properties.Resources.No_image;
            this.Bambini_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bambini_pic.ErrorImage = global::Maestre.Properties.Resources.No_image;
            this.Bambini_pic.Location = new System.Drawing.Point(310, 79);
            this.Bambini_pic.Name = "Bambini_pic";
            this.Bambini_pic.Size = new System.Drawing.Size(200, 200);
            this.Bambini_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bambini_pic.TabIndex = 132;
            this.Bambini_pic.TabStop = false;
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
            // LibriLetti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maestre.Properties.Resources.Sfondo_maestre;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.NLibriLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Indietro_button);
            this.Controls.Add(this.NomeStudScelto);
            this.Controls.Add(this.CogomeStudScelto);
            this.Controls.Add(this.ClasseStudScelto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bambini_pic);
            this.Controls.Add(this.TabellaBambini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibriLetti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibriLetti";
            this.Load += new System.EventHandler(this.LibriLetti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bambini_pic;
        private System.Windows.Forms.DataGridView TabellaBambini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ClasseStudScelto;
        private System.Windows.Forms.Label CogomeStudScelto;
        private System.Windows.Forms.Label NomeStudScelto;
        private System.Windows.Forms.Button Indietro_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bsLibri;
        private System.Windows.Forms.Label NLibriLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn titoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genereDataGridViewTextBoxColumn;
    }
}