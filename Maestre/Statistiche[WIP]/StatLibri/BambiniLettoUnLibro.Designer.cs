namespace Maestre.Statistiche_WIP_
{
    partial class BambiniLettoUnLibro
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
            this.label2 = new System.Windows.Forms.Label();
            this.titolotb = new System.Windows.Forms.TextBox();
            this.RicercaStatLibro = new System.Windows.Forms.Button();
            this.Indietro_button = new System.Windows.Forms.Button();
            this.LibroTabella = new System.Windows.Forms.DataGridView();
            this.titoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLibri = new System.Windows.Forms.BindingSource(this.components);
            this.autore_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generetb = new System.Windows.Forms.ComboBox();
            this.reset_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LibroTabella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cerca il titolo del libro";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(432, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TITOLO DEL LIBRO:";
            // 
            // titolotb
            // 
            this.titolotb.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.titolotb.Location = new System.Drawing.Point(648, 90);
            this.titolotb.Name = "titolotb";
            this.titolotb.Size = new System.Drawing.Size(276, 30);
            this.titolotb.TabIndex = 2;
            // 
            // RicercaStatLibro
            // 
            this.RicercaStatLibro.BackColor = System.Drawing.Color.Transparent;
            this.RicercaStatLibro.BackgroundImage = global::Maestre.Properties.Resources.cerca;
            this.RicercaStatLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RicercaStatLibro.FlatAppearance.BorderSize = 0;
            this.RicercaStatLibro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.RicercaStatLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RicercaStatLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RicercaStatLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RicercaStatLibro.Location = new System.Drawing.Point(955, 84);
            this.RicercaStatLibro.Name = "RicercaStatLibro";
            this.RicercaStatLibro.Size = new System.Drawing.Size(380, 120);
            this.RicercaStatLibro.TabIndex = 3;
            this.RicercaStatLibro.UseVisualStyleBackColor = false;
            this.RicercaStatLibro.Click += new System.EventHandler(this.RicercaStatLibro_Click);
            // 
            // Indietro_button
            // 
            this.Indietro_button.BackgroundImage = global::Maestre.Properties.Resources.Indietro;
            this.Indietro_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Indietro_button.FlatAppearance.BorderSize = 0;
            this.Indietro_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Indietro_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Indietro_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Indietro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Indietro_button.Location = new System.Drawing.Point(493, 636);
            this.Indietro_button.Name = "Indietro_button";
            this.Indietro_button.Size = new System.Drawing.Size(380, 120);
            this.Indietro_button.TabIndex = 4;
            this.Indietro_button.UseVisualStyleBackColor = true;
            this.Indietro_button.Click += new System.EventHandler(this.Button2_Click);
            // 
            // LibroTabella
            // 
            this.LibroTabella.AllowUserToAddRows = false;
            this.LibroTabella.AllowUserToDeleteRows = false;
            this.LibroTabella.AllowUserToOrderColumns = true;
            this.LibroTabella.AllowUserToResizeColumns = false;
            this.LibroTabella.AllowUserToResizeRows = false;
            this.LibroTabella.AutoGenerateColumns = false;
            this.LibroTabella.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LibroTabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibroTabella.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titoloDataGridViewTextBoxColumn,
            this.autoreDataGridViewTextBoxColumn,
            this.genereDataGridViewTextBoxColumn});
            this.LibroTabella.DataSource = this.bsLibri;
            this.LibroTabella.Location = new System.Drawing.Point(12, 210);
            this.LibroTabella.MultiSelect = false;
            this.LibroTabella.Name = "LibroTabella";
            this.LibroTabella.ReadOnly = true;
            this.LibroTabella.RowHeadersVisible = false;
            this.LibroTabella.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LibroTabella.Size = new System.Drawing.Size(1342, 420);
            this.LibroTabella.TabIndex = 5;
            this.LibroTabella.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LibroTabella_CellDoubleClick);
            this.LibroTabella.SelectionChanged += new System.EventHandler(this.LibroTabella_SelectionChanged);
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
            // autore_tb
            // 
            this.autore_tb.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.autore_tb.Location = new System.Drawing.Point(648, 127);
            this.autore_tb.Name = "autore_tb";
            this.autore_tb.Size = new System.Drawing.Size(276, 30);
            this.autore_tb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(420, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "AUTORE DEL LIBRO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(420, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "GENERE DEL LIBRO:";
            // 
            // generetb
            // 
            this.generetb.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.generetb.FormattingEnabled = true;
            this.generetb.Location = new System.Drawing.Point(648, 163);
            this.generetb.Name = "generetb";
            this.generetb.Size = new System.Drawing.Size(276, 31);
            this.generetb.TabIndex = 9;
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
            this.reset_button.Location = new System.Drawing.Point(12, 84);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(380, 120);
            this.reset_button.TabIndex = 10;
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BambiniLettoUnLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.generetb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.autore_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LibroTabella);
            this.Controls.Add(this.Indietro_button);
            this.Controls.Add(this.RicercaStatLibro);
            this.Controls.Add(this.titolotb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BambiniLettoUnLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e1";
            this.Load += new System.EventHandler(this.BambiniLettoUnLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibroTabella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titolotb;
        private System.Windows.Forms.Button RicercaStatLibro;
        private System.Windows.Forms.Button Indietro_button;
        private System.Windows.Forms.DataGridView LibroTabella;
        private System.Windows.Forms.DataGridViewTextBoxColumn titoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genereDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsLibri;
        private System.Windows.Forms.TextBox autore_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox generetb;
        private System.Windows.Forms.Button reset_button;
    }
}